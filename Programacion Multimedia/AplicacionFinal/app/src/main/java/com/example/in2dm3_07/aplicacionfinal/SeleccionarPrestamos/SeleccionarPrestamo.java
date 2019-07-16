package com.example.in2dm3_07.aplicacionfinal.SeleccionarPrestamos;

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
import com.example.in2dm3_07.aplicacionfinal.LlenarListView.tvAdapter;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Libros;
import com.example.in2dm3_07.aplicacionfinal.R;

import java.util.ArrayList;

/**
 * Created by Asier on 25/01/2018.
 */


public class SeleccionarPrestamo extends AppCompatActivity {
    //Exactamente igual que el NuevoPrestamo1, solo que esta vez mandamos tambien el Titulo para ponerlo en un TextBox.
    private ListView list;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private ArrayList<TextBoxes> listaInformacion = new ArrayList<>();
    private tvAdapter adaptador1;
    private String selectionArgs, ida, ida2;
    private Cursor cursor;
    private TextView myView, myView2;
    private Intent nuevoPrestamo2;
    private SQLiteDatabase db;
    private TextBoxes newTextBoxes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.libros_prestados);
        list = findViewById(R.id.listaPrestamos);
        db = helper.getReadableDatabase();
        String[] projection = {EstructuraDDBB_Libros.columnaISBN, EstructuraDDBB_Libros.columnaTitulo};
        selectionArgs = "IS NOT NULL";

        cursor = db.query(
                EstructuraDDBB_Libros.nombreTabla,             // The table to query
                projection,                                      // The columns to return
                EstructuraDDBB_Libros.columnaPrestado + " " + selectionArgs,                                   // The columns for the WHERE clause
                null,                                // The values for the WHERE clause
                null,                                   // don't group the rows
                null,                                    // don't filter by row groups
                EstructuraDDBB_Libros.columnaTitulo);                                  // The sort order
        cursor.moveToFirst();
        while (!cursor.isAfterLast()) {
            newTextBoxes = new TextBoxes(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaTitulo)), cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaISBN)));
            adaptador1 = new tvAdapter(this, listaInformacion);
            adaptador1.add(newTextBoxes);
            cursor.moveToNext();
        }
        cursor.close();
        list.setAdapter(adaptador1);
        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                myView = view.findViewById(R.id.tvNombreApellido);
                ida = (String) myView.getText();
                myView2 = view.findViewById(R.id.tvID);
                ida2 = (String) myView2.getText();
                nuevoPrestamo2 = new Intent(getApplicationContext(), SeleccionarPrestamo2.class);
                nuevoPrestamo2.putExtra("Titulo", ida);
                nuevoPrestamo2.putExtra("ISBN", ida2);
                startActivity(nuevoPrestamo2);
            }
        });
    }
}
