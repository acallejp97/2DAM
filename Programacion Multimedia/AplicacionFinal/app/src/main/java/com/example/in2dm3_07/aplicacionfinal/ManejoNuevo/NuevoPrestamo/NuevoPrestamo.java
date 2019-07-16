package com.example.in2dm3_07.aplicacionfinal.ManejoNuevo.NuevoPrestamo;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.TextView;

import com.example.in2dm3_07.aplicacionfinal.LlenarListView.TextBoxes;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;
import com.example.in2dm3_07.aplicacionfinal.LlenarListView.tvAdapter;

import java.util.ArrayList;

/**
 * Created by Asier on 24/01/2018.
 */

public class NuevoPrestamo extends AppCompatActivity {
    private ListView list;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private ArrayList<TextBoxes> listaInformacion = new ArrayList<>();
    private tvAdapter adaptador1;
    private SQLiteDatabase db;
    private TextView maView;
    private String ida;
    private Intent nuevoPresamo;
    private Cursor cursor;
    private TextBoxes newTextBoxes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.nuevo_prestamo1);
        list = findViewById(R.id.list1);

        //Aqui lo que hacemos es escoger el ID,
        // el nombre y el apellido de los usuarios
        // e imprimirlos en un objeto usuario, donde
        // posteriormente se imprimiran en la lista
        db = helper.getReadableDatabase();
        String[] projection = {EstructuraDDBB_Usuarios.columnaID, EstructuraDDBB_Usuarios.columnaNombre, EstructuraDDBB_Usuarios.columnaApellido};
        cursor = db.query(
                EstructuraDDBB_Usuarios.nombreTabla,             // The table to query
                projection,                                      // The columns to return
                null,                                   // The columns for the WHERE clause
                null,                                // The values for the WHERE clause
                null,                                   // don't group the rows
                null,                                    // don't filter by row groups
                EstructuraDDBB_Usuarios.columnaID);                                  // The sort order
        cursor.moveToFirst();

        while (!cursor.isAfterLast()) {
            newTextBoxes = new TextBoxes(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaNombre)) + " " + cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaApellido)), cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaID)));
            adaptador1 = new tvAdapter(this, listaInformacion);
            adaptador1.add(newTextBoxes);
            cursor.moveToNext();
        }

        cursor.close();
        list.setAdapter(adaptador1);
//aqui lo que hacemos es que al seleccionar un usuario, cogemos su id para posteriormente asignarselo al libro
        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                maView = view.findViewById(R.id.tvID);
                ida = maView.getText().toString();
                nuevoPresamo = new Intent(getApplicationContext(), NuevoPrestamo2.class);
                nuevoPresamo.putExtra("ID", ida);
                startActivity(nuevoPresamo);
            }
        });
    }
}