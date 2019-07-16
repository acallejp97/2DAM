package com.example.in2dm3_07.aplicacionfinal.ManejoNuevo;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.CursorIndexOutOfBoundsException;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Libros;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;

/**
 * Created by in2dm3_07 on 23/01/2018.
 */

public class NuevoLibro extends AppCompatActivity {


    //Esta clase está exactamente igual estructurada que al de Usuarios
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private Button btnAnadir, btnBorrar, btnBuscar, btnActualizar;
    private EditText tbISBN, tbTitulo, tbAutor, tbEditorial;
    private boolean dentro = false;
    private SQLiteDatabase db;
    private Cursor cursor;
    private ContentValues values;
    private String selection;

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putString("ISBN", tbISBN.getText().toString());
        outState.putString("Titulo", tbTitulo.getText().toString());
        outState.putString("Autor", tbAutor.getText().toString());
        outState.putString("Editorial", tbEditorial.getText().toString());
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.nuevo_libro);

        btnAnadir = findViewById(R.id.btnAnadir);
        btnBorrar = findViewById(R.id.btnBorrar);
        btnBuscar = findViewById(R.id.btnBuscar);
        btnActualizar=findViewById(R.id.btnActualizar);

        tbISBN = findViewById(R.id.tbISBN);
        tbTitulo = findViewById(R.id.tbTitulo);
        tbAutor = findViewById(R.id.tbAutor);
        tbEditorial = findViewById(R.id.tbEditorial);

        if (savedInstanceState != null) {
            tbISBN.setText(savedInstanceState.getString("ISBN"));
            tbTitulo.setText(savedInstanceState.getString("Titulo"));
            tbAutor.setText(savedInstanceState.getString("Autor"));
            tbEditorial.setText(savedInstanceState.getString("Editorial"));
        }
        btnAnadir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (tbISBN.getText().toString().equals("")||tbTitulo.getText().toString().equals("")||tbAutor.getText().toString().equals("")||tbEditorial.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                } else {
                    db = helper.getReadableDatabase();
                    String[] projection = {EstructuraDDBB_Libros.columnaISBN};
                    cursor = db.query(
                            EstructuraDDBB_Libros.nombreTabla,             // The table to query
                            projection,                                      // The columns to return
                            null,                                   // The columns for the WHERE clause
                            null,                                // The values for the WHERE clause
                            null,                                   // don't group the rows
                            null,                                    // don't filter by row groups
                            EstructuraDDBB_Libros.columnaTitulo);                                  // The sort order
                    cursor.moveToFirst();
                    dentro = false;
                    while (!cursor.isAfterLast()) {
                        if (cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Libros.columnaISBN)).matches(tbISBN.getText().toString()))
                            dentro = true;
                        cursor.moveToNext();
                    }
                    cursor.close();
                    if (dentro == true) {
                        Toast.makeText(getApplicationContext(), getString(R.string.ISBNExistente), Toast.LENGTH_LONG).show();
                    } else {
                        try {
                            db = helper.getWritableDatabase();
                            values = new ContentValues();
                            values.put(EstructuraDDBB_Libros.columnaISBN, tbISBN.getText().toString());
                            values.put(EstructuraDDBB_Libros.columnaTitulo, tbTitulo.getText().toString());
                            values.put(EstructuraDDBB_Libros.columnaAutor, tbAutor.getText().toString());
                            values.put(EstructuraDDBB_Libros.columnaEditorial, tbEditorial.getText().toString());
                            db.insert(EstructuraDDBB_Libros.nombreTabla, null, values);

                            Toast.makeText(getApplicationContext(), getString(R.string.GuardadoCorrectametne), Toast.LENGTH_LONG).show();
                        } catch (Exception ex) {
                            Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                        }

                        tbAutor.setText("");
                        tbEditorial.setText("");
                        tbISBN.setText("");
                        tbTitulo.setText("");
                    }
                }
            }
        });

        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    db = helper.getReadableDatabase();
                    String[] projection = {EstructuraDDBB_Libros.columnaTitulo, EstructuraDDBB_Libros.columnaAutor, EstructuraDDBB_Libros.columnaEditorial};
                    selection = EstructuraDDBB_Libros.columnaISBN + " = ?";
                    String[] selectionArgs = {tbISBN.getText().toString()};

                    cursor = db.query(
                            EstructuraDDBB_Libros.nombreTabla,               // The table to query
                            projection,                                      // The columns to return
                            selection,                                       // The columns for the WHERE clause
                            selectionArgs,                                   // The values for the WHERE clause
                            null,                                   // don't group the rows
                            null,                                    // don't filter by row groups
                            null                                    // The sort order
                    );
                    cursor.moveToFirst();
                    tbTitulo.setText(cursor.getString(0));
                    tbAutor.setText(cursor.getString(1));
                    tbEditorial.setText(cursor.getString(2));
                    cursor.close();

                } catch (CursorIndexOutOfBoundsException ex) {
                    Toast.makeText(getApplicationContext(), getString(R.string.ISBNExistente), Toast.LENGTH_LONG).show();
                }
            }
        });

        btnBorrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    db = helper.getWritableDatabase();
                    selection = EstructuraDDBB_Libros.columnaISBN + " LIKE ?";
                    String[] selectionArgs = {tbISBN.getText().toString()};
                    db.delete(EstructuraDDBB_Libros.nombreTabla, selection, selectionArgs);
                    Toast.makeText(getApplicationContext(), getString(R.string.ISBNBorrado) + tbISBN.getText(), Toast.LENGTH_LONG).show();
                    tbISBN.setText("");
                    tbAutor.setText("");
                    tbTitulo.setText("");
                    tbEditorial.setText("");

                } catch (Exception ex) {
                    Toast.makeText(getApplicationContext(), getString(R.string.ISBNVacio) + tbISBN.getText(), Toast.LENGTH_LONG).show();
                }
            }
        });
        btnActualizar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (tbISBN.getText().toString().equals("")||tbTitulo.getText().toString().equals("")||tbAutor.getText().toString().equals("")||tbEditorial.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                } else {
                    try {
                        db = helper.getWritableDatabase();
                        values.put(EstructuraDDBB_Libros.columnaTitulo, tbTitulo.getText().toString());
                        values.put(EstructuraDDBB_Libros.columnaAutor, tbAutor.getText().toString());
                        values.put(EstructuraDDBB_Libros.columnaEditorial, tbEditorial.getText().toString());
                        db.update(EstructuraDDBB_Libros.nombreTabla, values, EstructuraDDBB_Libros.columnaISBN + " = " + tbISBN.getText().toString(), null);
                        Toast.makeText(getApplicationContext(), getString(R.string.DatosModificados), Toast.LENGTH_LONG).show();
                    } catch (Exception e) {
                    Toast.makeText(getApplicationContext(),getString(R.string.ErrorCampo),Toast.LENGTH_LONG).show();
                    }
                }
            }
        });

    }


}



