package com.example.in2dm3_07.aplicacionfinal.CargarMenu;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.TextView;

import com.example.in2dm3_07.aplicacionfinal.CargarMenu.Individual.LibrosIndividual;
import com.example.in2dm3_07.aplicacionfinal.LlenarListView.TextBoxes;
import com.example.in2dm3_07.aplicacionfinal.LlenarListView.tvAdapter;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Libros;
import com.example.in2dm3_07.aplicacionfinal.R;

import java.util.ArrayList;

/**
 * Created by Asier on 26/01/2018.
 */
//Escogemos todos los libros que estan en la lista y los imprimimos.
public class Libros extends AppCompatActivity {
    private ListView list;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private ArrayList<TextBoxes> listaInformacion = new ArrayList<>();
    private tvAdapter adaptador1;
    private SQLiteDatabase db;
    private Cursor cursor;
    private String ida2;
    private Intent nuevoPrestamo2;
    private TextView myView2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.carga_ddbb_libros);
        list = findViewById(R.id.listaLibros);
        db = helper.getReadableDatabase();
        String[] projection = {EstructuraDDBB_Libros.columnaISBN, EstructuraDDBB_Libros.columnaTitulo};


        cursor = db.query(
                EstructuraDDBB_Libros.nombreTabla,             // The table to query
                projection,                                      // The columns to return
                null,                                   // The columns for the WHERE clause
                null,                                // The values for the WHERE clause
                null,                                   // don't group the rows
                null,                                    // don't filter by row groups
                EstructuraDDBB_Libros.columnaISBN);                                  // The sort order
        cursor.moveToFirst();
        while (!cursor.isAfterLast()) {
            TextBoxes newTextBoxes = new TextBoxes(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaTitulo)), cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaISBN)));
            adaptador1 = new tvAdapter(this, listaInformacion);
            adaptador1.add(newTextBoxes);
            cursor.moveToNext();
        }
        cursor.close();
        list.setAdapter(adaptador1);list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                myView2 = view.findViewById(R.id.tvID);
                ida2 = (String) myView2.getText();
                nuevoPrestamo2 = new Intent(getApplicationContext(), LibrosIndividual.class);
                nuevoPrestamo2.putExtra("ISBN", ida2);
                startActivity(nuevoPrestamo2);
            }
        });

    }
}
