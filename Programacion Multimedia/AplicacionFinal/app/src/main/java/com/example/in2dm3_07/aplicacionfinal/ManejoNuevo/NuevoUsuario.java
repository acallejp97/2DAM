package com.example.in2dm3_07.aplicacionfinal.ManejoNuevo;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.CursorIndexOutOfBoundsException;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.QuickContactBadge;
import android.widget.Toast;

import com.example.in2dm3_07.aplicacionfinal.LlenarListView.TextBoxes;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;

import java.util.ArrayList;

/**
 * Created by Asier on 22/01/2018.
 */

public class NuevoUsuario extends AppCompatActivity {

    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private SQLiteDatabase db;
    private Button btnAnadir, btnBorrar, btnBuscar, btnActualizar;
    private EditText tbID, tbNombre, tbApellido, tbTelefono;
    private boolean dentro;
    private String selection;
    private Cursor cursor;
    private ContentValues values;

    //guardamos los datos por si giramos el movil
    @Override
    public void onSaveInstanceState(Bundle outState, PersistableBundle outPersistentState) {
        super.onSaveInstanceState(outState, outPersistentState);
        outState.putString("ID", tbID.getText().toString());
        outState.putString("Nombre", tbNombre.getText().toString());
        outState.putString("Apellido", tbApellido.getText().toString());
        outState.putString("Telefono", tbTelefono.getText().toString());

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.nuevo_usuario);

        btnAnadir = findViewById(R.id.btnAnadir);
        btnBorrar = findViewById(R.id.btnBorrar);
        btnBuscar = findViewById(R.id.btnBuscar);
        btnActualizar = findViewById(R.id.btnActualizar);

        tbID = findViewById(R.id.tbID);
        tbNombre = findViewById(R.id.tbNombre);
        tbApellido = findViewById(R.id.tbApellido);
        tbTelefono = findViewById(R.id.tbTelefono);

        //Recogemos los datos por si hemos girado el telefono
        if (savedInstanceState != null) {
            tbID.setText(savedInstanceState.getString("ID"));
            tbNombre.setText(savedInstanceState.getString("Nombre"));
            tbApellido.setText(savedInstanceState.getString("Apellido"));
            tbTelefono.setText(savedInstanceState.getString("Telefono"));
        }

        //Añadir
        btnAnadir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                //Revisa que no este vacio el ID
                if (tbID.getText().toString().equals("") || tbNombre.getText().toString().equals("") || tbApellido.getText().toString().equals("") || tbTelefono.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                } else {
                    //Comprobamos que el ID que se ha escogido no este en uso con un cursor
                    db = helper.getReadableDatabase();
                    String[] projection = {EstructuraDDBB_Usuarios.columnaID};
                    cursor = db.query(
                            EstructuraDDBB_Usuarios.nombreTabla,              // Tabla donde hacer la consulta
                            projection,                                      // Columnas a devolver
                            null,                                  // Columnas donde hacer el WHERE
                            null,                               // Valores para la columna WHERE
                            null,                                   // Agrupar los resultados
                            null,                                    // Tener en cuenta lo siguiente
                            null                                    // Ordenar en base a lo siguiente
                    );
                    //Lo movemos a la primera posicion porque al hacer la consulta esta al final
                    cursor.moveToFirst();
                    dentro = false;
                    //recorre los datos recibidos de la DDBB
                    while (!cursor.isAfterLast()) {
                        if (cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaID)).matches(tbID.getText().toString()))
                            dentro = true;
                        cursor.moveToNext();
                    }
                    cursor.close();
                    if (dentro == true) {
                        Toast.makeText(getApplicationContext(), getString(R.string.IDExistente), Toast.LENGTH_LONG).show();

                        //Si no esta el ID dentro de la base de datos insertamos al usuario dentro de la base de datos
                    } else {
                        try {
                            //Hacemos una llamada al helper con caracteristicas de poder escribir en la base de datos
                            db = helper.getWritableDatabase();

                            //Añadimos todos los valores al Content Value
                            values = new ContentValues();
                            values.put(EstructuraDDBB_Usuarios.columnaID, tbID.getText().toString());
                            values.put(EstructuraDDBB_Usuarios.columnaNombre, tbNombre.getText().toString());
                            values.put(EstructuraDDBB_Usuarios.columnaApellido, tbApellido.getText().toString());
                            values.put(EstructuraDDBB_Usuarios.columnaTlf, tbTelefono.getText().toString());

                            //Lo insertamos en la base de datos
                            db.insert(EstructuraDDBB_Usuarios.nombreTabla, null, values);

                            Toast.makeText(getApplicationContext(), getString(R.string.GuardadoCorrectametne), Toast.LENGTH_LONG).show();
                        } catch (Exception ex) {
                            Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                        }
                        //Lo ponemos todo en blanco por si queremos añadir otro usuario.
                        tbApellido.setText("");
                        tbID.setText("");
                        tbNombre.setText("");
                        tbTelefono.setText("");
                    }
                }

            }
        });


        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    //Para buscar un usuario por ID el lo mismo que añadir, pero le metemos un WHERE y para sacar los datos con un getString
                    //En otra clase he usado un rawQuery, pero las dos me han funcionado
                    db = helper.getReadableDatabase();
                    String[] projection = {EstructuraDDBB_Usuarios.columnaNombre, EstructuraDDBB_Usuarios.columnaApellido, EstructuraDDBB_Usuarios.columnaTlf};
                    selection = EstructuraDDBB_Usuarios.columnaID + " = ?";
                    String[] selectionArgs = {tbID.getText().toString()};
                    cursor = db.query(
                            EstructuraDDBB_Usuarios.nombreTabla,              // The table to query
                            projection,                                      // The columns to return
                            selection,                                       // The columns for the WHERE clause
                            selectionArgs,                                   // The values for the WHERE clause
                            null,                                   // don't group the rows
                            null,                                    // don't filter by row groups
                            null                                    // The sort order
                    );
                    cursor.moveToFirst();
                    tbNombre.setText(cursor.getString(0));
                    tbApellido.setText(cursor.getString(1));
                    tbTelefono.setText(cursor.getString(2));
                    cursor.close();

                } catch (CursorIndexOutOfBoundsException ex) {
                    Toast.makeText(getApplicationContext(), getString(R.string.IDInexistemte), Toast.LENGTH_LONG).show();
                }
            }
        });

        btnBorrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //Para borrar cogemos la base de datos y buscamos el ID del que queremos eliminar
                try {
                    db = helper.getWritableDatabase();
                    selection = EstructuraDDBB_Usuarios.columnaID + " LIKE ?";
                    String[] selectionArgs = {tbID.getText().toString()};
                    db.delete(EstructuraDDBB_Usuarios.nombreTabla, selection, selectionArgs);

                    Toast.makeText(getApplicationContext(), getString(R.string.IDBorrado) + " " + tbID.getText(), Toast.LENGTH_LONG).show();

                    tbID.setText("");
                    tbApellido.setText("");
                    tbNombre.setText("");
                    tbTelefono.setText("");

                } catch (Exception ex) {
                    Toast.makeText(getApplicationContext(), getString(R.string.IDInexistemte), Toast.LENGTH_LONG).show();
                }
            }
        });

        btnActualizar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (tbID.getText().toString().equals("") || tbNombre.getText().toString().equals("") || tbApellido.getText().toString().equals("") || tbTelefono.getText().toString().equals("")) {
                    Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                } else {
                    try {
                        db = helper.getWritableDatabase();
                        values.put(EstructuraDDBB_Usuarios.columnaNombre, tbNombre.getText().toString());
                        values.put(EstructuraDDBB_Usuarios.columnaApellido, tbApellido.getText().toString());
                        values.put(EstructuraDDBB_Usuarios.columnaTlf, tbTelefono.getText().toString());
                        db.update(EstructuraDDBB_Usuarios.nombreTabla, values, EstructuraDDBB_Usuarios.columnaID + " = " + tbID.getText().toString(), null);
                        Toast.makeText(getApplicationContext(), getString(R.string.DatosModificados), Toast.LENGTH_SHORT).show();
                    } catch (Exception e) {
                        Toast.makeText(getApplicationContext(), getString(R.string.ErrorCampo), Toast.LENGTH_LONG).show();
                    }
                }
            }
        });
    }
}

