package com.example.in2dm3_07.aplicacionfinal.CargarMenu.Individual;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.TextView;

import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Libros;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;

/**
 * Created by Asier on 26/01/2018.
 */
public class LibrosIndividual extends AppCompatActivity {
    private TextView tvISBN, tvTitulo, tvAutor, tvEditorial, tvLibrosPrestados;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private String ISBN, sentencia;
    private SQLiteDatabase db;
    private Cursor c;

    //Imprimimos todos los datos del libro seleccionado
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.carga_ddbb_libros2);
        tvISBN = findViewById(R.id.tvISBNddbb);
        tvTitulo = findViewById(R.id.tvTituloddbb);
        tvAutor = findViewById(R.id.tvAutorddbb);
        tvEditorial = findViewById(R.id.tvEditorialddbb);
        tvLibrosPrestados = findViewById(R.id.tvPrestadoddbbb);

        try {
            ISBN = getIntent().getStringExtra("ISBN");
            sentencia = "SELECT " + EstructuraDDBB_Libros.columnaISBN + " ," + EstructuraDDBB_Libros.columnaTitulo + " , " + EstructuraDDBB_Libros.columnaAutor + " , " + EstructuraDDBB_Libros.columnaEditorial + " , " + EstructuraDDBB_Libros.columnaPrestado + " FROM " + EstructuraDDBB_Libros.nombreTabla + " WHERE " + EstructuraDDBB_Libros.columnaISBN + " LIKE " + ISBN;
            db = helper.getReadableDatabase();
            c = null;
            c = db.rawQuery(sentencia, null);
            c.moveToFirst();
            tvISBN.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaISBN)));
            tvTitulo.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaTitulo)));
            tvAutor.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaAutor)));
            tvEditorial.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaEditorial)));
            if (c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaPrestado)) == null) {
                tvLibrosPrestados.setText(getString(R.string.No));
            } else {
                tvLibrosPrestados.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaPrestado)));
            }
            c.close();


        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
