package com.example.in2dm3_07.aplicacionfinal.SeleccionarPrestamos;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.net.Uri;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.example.in2dm3_07.aplicacionfinal.MainActivity;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Libros;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;

/**
 * Created by Asier on 25/01/2018.
 */

public class SeleccionarPrestamo2 extends AppCompatActivity {
    private TextView tvID, tvNombre, tvApellido, tvTelefono, tvLibrosPrestados, tvTitulo;
    private Button btnDevuelto, btnLlamar;
    private static final int MY_PERMISSIONS_REQUEST_WRITE_EXTERNAL_STORAGE = 1;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private String ISBN, sentencia, resp, update;
    private int libros, permissionCheck;
    private SQLiteDatabase db;
    private Cursor c, cursor;
    private Intent inicio, i;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.libros_prestados2);
        tvID = findViewById(R.id.tvIDPrestado);
        tvNombre = findViewById(R.id.tvNombrePrestado);
        tvApellido = findViewById(R.id.tvApellidoPrestado);
        tvTelefono = findViewById(R.id.tvTelefonoPrestado);
        tvLibrosPrestados = findViewById(R.id.tvLibrosPrestado);
        tvTitulo = findViewById(R.id.tvTituloPrestado);

        btnDevuelto = findViewById(R.id.btnDevuelto);
        btnLlamar = findViewById(R.id.btnLLamar);

        tvTitulo.setText(getIntent().getStringExtra("Titulo"));

        try {
            //Cogemos el Intent enviado a esta clase para hacer un select de la persona que ha cogido prestado el libro
            ISBN = getIntent().getStringExtra("ISBN");
            sentencia = "SELECT " + EstructuraDDBB_Libros.columnaPrestado + " FROM " + EstructuraDDBB_Libros.nombreTabla + " WHERE " + EstructuraDDBB_Libros.columnaISBN + " LIKE " + ISBN;
            db = helper.getReadableDatabase();
            c = null;
            c = db.rawQuery(sentencia, null);
            c.moveToFirst();
            //El ID del que lo ha cogido prestado
            resp = c.getString(c.getColumnIndex(EstructuraDDBB_Libros.columnaPrestado));
            c.close();
            tvID.setText(resp);
            llamarUsuario(resp, db);

        } catch (Exception e) {
            e.printStackTrace();

        }
        //Aqui reducimos en 1 los libros que tiene cogidos el usuario
        //Tambien catualizamos la tabla de libros para indicar que este está vacio
        btnDevuelto.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                db = helper.getWritableDatabase();
                ISBN = getIntent().getStringExtra("ISBN");
                update = "update " + EstructuraDDBB_Libros.nombreTabla + " SET " + EstructuraDDBB_Libros.columnaPrestado + " = NULL WHERE " + EstructuraDDBB_Libros.columnaISBN + " = " + ISBN;
                db.execSQL(update);
                //reducir en 1 los libros cogidos.
                libros = Integer.parseInt(tvLibrosPrestados.getText().toString());
                libros = libros - 1;
                if (libros == 0) {
                    update = "update " + EstructuraDDBB_Usuarios.nombreTabla + " SET " + EstructuraDDBB_Usuarios.columnaPrestados + " = NULL WHERE " + EstructuraDDBB_Usuarios.columnaID + " = " + tvID.getText().toString();
                } else {
                    update = "update " + EstructuraDDBB_Usuarios.nombreTabla + " SET " + EstructuraDDBB_Usuarios.columnaPrestados + " = " + libros + " WHERE " + EstructuraDDBB_Usuarios.columnaID + " = " + tvID.getText().toString();
                }
                db.execSQL(update);
                //Aqui se vuelve al inicio
                Toast.makeText(getApplicationContext(), getString(R.string.LibroDevuelto), Toast.LENGTH_LONG).show();
                inicio = new Intent(getApplicationContext(), MainActivity.class);
                finish();
                startActivity(inicio);

            }
        });

    }

    //comprobamos si nos han concedido el permiso de llamada
    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        switch (requestCode) {
            case MY_PERMISSIONS_REQUEST_WRITE_EXTERNAL_STORAGE: {
                // If request is cancelled, the result arrays are empty.
                if (grantResults.length > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                } else {
                }
                return;
            }
        }
    }

    //Pedir permiso de llamada al telefono
    public void pedirPermiso() {
        permissionCheck = ContextCompat.checkSelfPermission(this, Manifest.permission.CALL_PHONE);
        if (ContextCompat.checkSelfPermission(this,
                Manifest.permission.CALL_PHONE)
                != PackageManager.PERMISSION_GRANTED) {
            if (ActivityCompat.shouldShowRequestPermissionRationale(this, Manifest.permission.CALL_PHONE)) {
            } else {
                ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.CALL_PHONE}, MY_PERMISSIONS_REQUEST_WRITE_EXTERNAL_STORAGE
                );
            }
        }
    }

    //Aqui llamamos (Se ha usado la opcion on click del layout)
    public void Llamar(View v) {
        pedirPermiso();

        i = new Intent(Intent.ACTION_CALL);
        i.setData(Uri.parse("tel:" + tvTelefono.getText().toString()));
        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.CALL_PHONE) != PackageManager.PERMISSION_GRANTED) {
            return;
        }
        startActivity(i);
    }

    //Con esto llenamos los datos que se mostraran en el layout
    public void llamarUsuario(String ID, SQLiteDatabase db) {
        tvID = findViewById(R.id.tvIDPrestado);
        tvNombre = findViewById(R.id.tvNombrePrestado);
        tvApellido = findViewById(R.id.tvApellidoPrestado);
        tvTelefono = findViewById(R.id.tvTelefonoPrestado);
        tvLibrosPrestados = findViewById(R.id.tvLibrosPrestado);

        sentencia = "SELECT " + EstructuraDDBB_Usuarios.columnaApellido + ", " + EstructuraDDBB_Usuarios.columnaNombre + ", " + EstructuraDDBB_Usuarios.columnaPrestados + ", "
                + EstructuraDDBB_Usuarios.columnaTlf + " FROM " + EstructuraDDBB_Usuarios.nombreTabla +
                " WHERE " + EstructuraDDBB_Usuarios.columnaID + " LIKE " + ID;
        cursor = db.rawQuery(sentencia, null);                              // The sort order
        cursor.moveToFirst();
        tvTelefono.setText(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaTlf)));
        tvLibrosPrestados.setText(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaPrestados)));
        tvApellido.setText(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaApellido)));
        tvNombre.setText(cursor.getString(cursor.getColumnIndex(EstructuraDDBB_Usuarios.columnaNombre)));
        cursor.close();

    }
}
