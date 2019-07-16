package com.example.in2dm3_07.aplicacionfinal;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;

import com.example.in2dm3_07.aplicacionfinal.CargarMenu.AcercaDe;
import com.example.in2dm3_07.aplicacionfinal.CargarMenu.Libros;
import com.example.in2dm3_07.aplicacionfinal.CargarMenu.Usuarios;
import com.example.in2dm3_07.aplicacionfinal.ManejoNuevo.NuevoLibro;
import com.example.in2dm3_07.aplicacionfinal.ManejoNuevo.NuevoPrestamo.NuevoPrestamo;
import com.example.in2dm3_07.aplicacionfinal.ManejoNuevo.NuevoUsuario;
import com.example.in2dm3_07.aplicacionfinal.SeleccionarPrestamos.SeleccionarPrestamo;

public class MainActivity extends AppCompatActivity {
    private Button btnNuevoUsuario, btnLibrosPrestados, btnNuevoPrestamo, btnNuevoLibro;
    private Intent about, nuevoLibro, nuevoPrestamo, nuevoUsuario, prestamos;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnNuevoUsuario = findViewById(R.id.btnNuevoUsuario);
        btnLibrosPrestados = findViewById(R.id.btnLibros);
        btnNuevoPrestamo = findViewById(R.id.btnNuevoPrestamo);
        btnNuevoLibro = findViewById(R.id.btnNuevoLibro);

        btnNuevoUsuario.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                nuevoUsuario = new Intent(getApplicationContext(), NuevoUsuario.class);
                startActivity(nuevoUsuario);
            }

        });

        btnNuevoLibro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                nuevoLibro = new Intent(getApplicationContext(), NuevoLibro.class);
                startActivity(nuevoLibro);
            }
        });

        btnNuevoPrestamo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                nuevoPrestamo = new Intent(getApplicationContext(), NuevoPrestamo.class);
                startActivity(nuevoPrestamo);
            }
        });

        btnLibrosPrestados.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                prestamos = new Intent(getApplicationContext(), SeleccionarPrestamo.class);
                startActivity(prestamos);
            }
        });
    }

    //Creamos el menu con los tres puntos del lateral derecho del main
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    //Escogemos la accion que hacen en cada boton
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();

        if (id == R.id.acercaDe) {
            about = new Intent(getApplicationContext(), AcercaDe.class);
            startActivity(about);
            return true;
        } else if (id == R.id.usuarios) {
            about = new Intent(getApplicationContext(), Usuarios.class);
            startActivity(about);
            return true;
        } else if (id == R.id.libros) {
            about = new Intent(getApplicationContext(), Libros.class);
            startActivity(about);
            return true;
        }

        return true;
    }
}
