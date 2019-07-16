package com.example.in2dm3_07.aplicacionfinal.CargarMenu.Individual;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.TextView;

import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.DDBB_HELPER;
import com.example.in2dm3_07.aplicacionfinal.ManejoDDBB.EstructuraDDBB_Usuarios;
import com.example.in2dm3_07.aplicacionfinal.R;

/**
 * Created by Asier on 26/01/2018.
 */
public class UsuariosIndividual extends AppCompatActivity {
    private TextView tvID, tvNombre, tvApellido, tvTelefono, tvLibrosPrestados;
    private DDBB_HELPER helper = new DDBB_HELPER(this);
    private String ISBN,sentencia;
    private SQLiteDatabase db;
    private Cursor c;


//Imprimimos todos los datos del usuario seleccionado
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.carga_ddbb_usuarios2);
        tvID = findViewById(R.id.tvIDddbb);
        tvNombre = findViewById(R.id.tvNombreddbb);
        tvApellido = findViewById(R.id.tvApellidoddbb);
        tvTelefono = findViewById(R.id.tvTelefonoddbb);
        tvLibrosPrestados = findViewById(R.id.tvLibrosddbb);

        try {
            ISBN = getIntent().getStringExtra("ID");
            sentencia = "SELECT " + EstructuraDDBB_Usuarios.columnaID + " ," + EstructuraDDBB_Usuarios.columnaNombre + " , " + EstructuraDDBB_Usuarios.columnaApellido + " , " + EstructuraDDBB_Usuarios.columnaTlf + " , " + EstructuraDDBB_Usuarios.columnaPrestados + " FROM " + EstructuraDDBB_Usuarios.nombreTabla + " WHERE " + EstructuraDDBB_Usuarios.columnaID + " LIKE " + ISBN;
            db = helper.getReadableDatabase();
            c = db.rawQuery(sentencia, null);
            c.moveToFirst();
            tvID.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Usuarios.columnaID)));
            tvNombre.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Usuarios.columnaNombre)));
            tvApellido.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Usuarios.columnaApellido)));
            tvTelefono.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Usuarios.columnaTlf)));
            tvLibrosPrestados.setText(c.getString(c.getColumnIndex(EstructuraDDBB_Usuarios.columnaPrestados)));

            c.close();


        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
