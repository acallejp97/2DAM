package com.example.in2dm3_07.aplicacionfinal.ManejoNuevo.NuevoPrestamo;

import android.app.NotificationManager;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v4.app.NotificationCompat;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.in2dm3_07.aplicacionfinal.LlenarListView.TextBoxes;
import com.example.in2dm3_07.aplicacionfinal.MainActivity;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Libros;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;
import com.example.in2dm3_07.aplicacionfinal.LlenarListView.tvAdapter;

import java.util.ArrayList;

/**
 * Created by Asier on 24/01/2018.
 */

public class NuevoPrestamo2 extends AppCompatActivity {

    private ListView list;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private ArrayList<TextBoxes> listaInformacion = new ArrayList<>();
    private tvAdapter adaptador1;
    private String ida, nombre, selectionArgs, ISBN, update;
    private TextView tvID, myView, tvNameNombreApellido;
    private Cursor cursor;
    private SQLiteDatabase db;
    private TextBoxes newTextBoxes;
    private NotificationManager mNotifyMgr;
    private NotificationCompat.Builder mBuilder;
    private int icono;
    private Intent vueltaAlInicio;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.nuevo_prestamo2);
        ida = getIntent().getStringExtra("ID");

        list = findViewById(R.id.list2);
        tvID = findViewById(R.id.tvIDRecogido);

        //Este es un TextBox para saber si el ID ha llegado bien al otro layout
        tvID.setText(ida);

        //Hacemos una consulta que seleccionara aquellos libros  que no estan prestados y llenamos la lista
        db = helper.getReadableDatabase();
        String[] projection = {EstructuraDDBB_Libros.columnaISBN, EstructuraDDBB_Libros.columnaTitulo};
        selectionArgs = "IS NULL";
        cursor = db.query(
                EstructuraDDBB_Libros.nombreTabla,             // The table to query
                projection,                                      // The columns to return
                EstructuraDDBB_Libros.columnaPrestado + " " + selectionArgs,                                   // The columns for the WHERE clause
                null,                                // The values for the WHERE clause
                null,                                   // don't group the rows
                null,                                    // don't filter by row groups
                EstructuraDDBB_Libros.columnaISBN);                                  // The sort order
        cursor.moveToFirst();

        while (!cursor.isAfterLast()) {
            newTextBoxes = new TextBoxes(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaTitulo)), cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaISBN)));
            adaptador1 = new tvAdapter(this, listaInformacion);
            adaptador1.add(newTextBoxes);
            cursor.moveToNext();
        }
        cursor.close();
        list.setAdapter(adaptador1);

        //Ahora al meterlo al clickarlo tendremos que actualizar la columna de prestado de la tabla Libro y del usuario, para asi asignarles los libros a cada uno, aunque en el caso del usuario
        //contador de libros prestados
        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                myView = view.findViewById(R.id.tvID);
                ISBN = (String) myView.getText();
                db = helper.getReadableDatabase();
                update = "update " + EstructuraDDBB_Libros.nombreTabla + " SET " + EstructuraDDBB_Libros.columnaPrestado + " = " + ida + " WHERE " + EstructuraDDBB_Libros.columnaISBN + " = " + ISBN;
                db.execSQL(update);
                //Aqui miramos el contador del usuario, para sumarle uno.
                anadirDatosUsuario(ida, helper);

                //Llamamos a la notificacion
                notificacion();

                //Aqiu volvemos al inicio, ya que no tiene sentido quedarse ahi.
                Toast.makeText(getApplicationContext(), getString(R.string.LibroPrestado), Toast.LENGTH_LONG).show();
                vueltaAlInicio = new Intent(getApplicationContext(), MainActivity.class);
                finish();
                startActivity(vueltaAlInicio);


            }
        });


    }

    public static void anadirDatosUsuario(String ida, DDBB_HELPER helper) {
        //Los declaramos aqui porque es un metodo estatico
        String ID, sentencia, resp;
        int cant;
        SQLiteDatabase db;
        Cursor c;
        //Seleccionamos la cantidad de libros que tiene prestados
        try {
            ID = ida;
            sentencia = "SELECT " + EstructuraDDBB_Usuarios.columnaPrestados + " FROM " + EstructuraDDBB_Usuarios.nombreTabla + " WHERE " + EstructuraDDBB_Usuarios.columnaID + " LIKE " + ID;
            db = helper.getReadableDatabase();
            //Esta es la rawQuey que mencione en la anterior clase
            c = db.rawQuery(sentencia, null);
            c.moveToFirst();
            resp = c.getString(c.getColumnIndex(EstructuraDDBB_Usuarios.columnaPrestados));
            c.close();
            //si es null hay que decir que son 0
            if (resp == null) {
                resp = "0";
            }

            cant = Integer.parseInt(resp) + 1;
            sentencia = "UPDATE " + EstructuraDDBB_Usuarios.nombreTabla + " SET " + EstructuraDDBB_Usuarios.columnaPrestados + " = " + cant + " WHERE " + EstructuraDDBB_Usuarios.columnaID + " LIKE " + ID;
            db.execSQL(sentencia);

        } catch (Exception e) {
            e.printStackTrace();
        }

    }

    //aqui creamos la notificación
    public void notificacion() {
        tvNameNombreApellido = findViewById(R.id.tvNombreApellido);
        nombre = tvNameNombreApellido.getText().toString();
        mNotifyMgr = (NotificationManager) getApplicationContext().getSystemService(NOTIFICATION_SERVICE);
        icono = R.mipmap.ic_launcher;

        mBuilder = new NotificationCompat.Builder(getApplicationContext())
                .setContentIntent(null)
                .setSmallIcon(icono)
                .setContentTitle(getString(R.string.LibroPrestado))
                .setContentText(getString(R.string.ElLibro) + " " + nombre + " " + getString(R.string.HaSidoPrestado))
                .setVibrate(new long[]{100, 250, 100, 500})
                .setAutoCancel(true);
        mNotifyMgr.notify(1, mBuilder.build());
    }

}