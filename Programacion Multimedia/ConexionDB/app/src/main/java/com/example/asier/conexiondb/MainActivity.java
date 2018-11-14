package com.example.asier.conexiondb;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.CursorIndexOutOfBoundsException;
import android.database.sqlite.SQLiteDatabase;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.asier.conexiondb.ManejoBBDD.BBDD_HELPER;
import com.example.asier.conexiondb.ManejoBBDD.Estructura_BaseDatos;

import static java.security.AccessController.getContext;

public class MainActivity extends AppCompatActivity {

    BBDD_HELPER helper = new BBDD_HELPER(this);

    Button btnInsertar, btnActualizar, btnBorrar, btnBuscar;
    EditText tbID, tbNombre, tbEmail;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnInsertar = findViewById(R.id.insertar);
        btnBorrar = findViewById(R.id.borrar);
        btnBuscar = findViewById(R.id.buscar);
        btnActualizar = findViewById(R.id.actualizar);

        tbID = findViewById(R.id.ID);
        tbNombre = findViewById(R.id.Nombre);
        tbEmail = findViewById(R.id.Email);

        btnInsertar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Gets the data repository in write mode
                SQLiteDatabase db = helper.getWritableDatabase();

                // Create a new map of values, where column names are the keys
                ContentValues values = new ContentValues();
                values.put(Estructura_BaseDatos.columnaID, tbID.getText().toString());
                values.put(Estructura_BaseDatos.columnaNombre, tbNombre.getText().toString());
                values.put(Estructura_BaseDatos.columnaEmail, tbEmail.getText().toString());

                // Insert the new row, returning the primary key value of the new row
                long meterEnTabla = db.insert(Estructura_BaseDatos.nombreTabla, null, values);

                Toast.makeText(getApplicationContext(), "Guardado correctamente", Toast.LENGTH_LONG).show();

            }
        });

        btnActualizar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                SQLiteDatabase db = helper.getWritableDatabase();

// New value for one column
                ContentValues values = new ContentValues();
                values.put(Estructura_BaseDatos.columnaNombre, tbNombre.getText().toString());
                values.put(Estructura_BaseDatos.columnaEmail, tbEmail.getText().toString());

// Which row to update, based on the title
                String selection = Estructura_BaseDatos.columnaID + " LIKE ?";
                String[] selectionArgs = {tbID.getText().toString()};

                int count = db.update(
                        Estructura_BaseDatos.nombreTabla,
                        values,
                        selection,
                        selectionArgs);
                Toast.makeText(getApplicationContext(),"Columna "+tbID.getText().toString()+" actualizada",Toast.LENGTH_LONG).show();
            }

        });

        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    SQLiteDatabase db = helper.getReadableDatabase();

// Define a projection that specifies which columns from the database
// you will actually use after this query.
                    String[] projection = {Estructura_BaseDatos.columnaNombre, Estructura_BaseDatos.columnaEmail};

// Filter results WHERE "title" = 'My Title'
                    String selection = Estructura_BaseDatos.columnaID + " = ?";
                    String[] selectionArgs = {tbID.getText().toString()};

// How you want the results sorted in the resulting Cursor

                    Cursor cursor = db.query(
                            Estructura_BaseDatos.nombreTabla,                      // The table to query
                            projection,                                           // The columns to return
                            selection,                                           // The columns for the WHERE clause
                            selectionArgs,                                      // The values for the WHERE clause
                            null,                                     // don't group the rows
                            null,                                     // don't filter by row groups
                            null                                    // The sort order
                    );
                    cursor.moveToFirst();
                    tbNombre.setText(cursor.getString(0));
                    tbEmail.setText(cursor.getString(1));
                    cursor.close();

                } catch (CursorIndexOutOfBoundsException ex) {
                    Toast.makeText(getApplicationContext(), "No existe nadie con ese ID", Toast.LENGTH_LONG).show();
                }
            }
        });

        btnBorrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    SQLiteDatabase db = helper.getWritableDatabase();

// Define 'where' part of query.
                    String selection = Estructura_BaseDatos.columnaID + " LIKE ?";
// Specify arguments in placeholder order.
                    String[] selectionArgs = {tbID.getText().toString()};
// Issue SQL statement.
                    db.delete(Estructura_BaseDatos.nombreTabla, selection, selectionArgs);
                    Toast.makeText(getApplicationContext(), "Se borro la entrada con id " + tbID.getText(), Toast.LENGTH_LONG).show();
                    tbEmail.setText("");
                    tbNombre.setText("");

                } catch (Exception ex) {
                    Toast.makeText(getApplicationContext(), "No hay ninguna entrada con id " + tbID.getText(), Toast.LENGTH_LONG).show();
                }
            }
        });
    }


}
