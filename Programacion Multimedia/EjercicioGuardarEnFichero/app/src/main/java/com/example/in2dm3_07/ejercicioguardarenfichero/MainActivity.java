package com.example.in2dm3_07.ejercicioguardarenfichero;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class MainActivity extends AppCompatActivity {

    //Declarar lo de guardado
    private FileOutputStream fo;
    private OutputStreamWriter oSW;

    //declarar lo cargado
    private FileInputStream fi;
    private InputStreamReader iSR;

    private EditText texto;
    private String fichero = "miFichero.txt";
    private String leido = "";

    static final int READ_BLOCK_SIZE = 100;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        texto = findViewById(R.id.tbTexto);


    }

    public void btnGuardarClicked(View view) {

        try {
            fo = openFileOutput(fichero, MODE_PRIVATE);
            oSW = new OutputStreamWriter(fo);
            oSW.write(texto.getText().toString());
            oSW.flush();

            Toast.makeText(getBaseContext(), "Guardado", Toast.LENGTH_LONG).show();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    public void btnMostrarClicked(View view) {
        try {

            fi = openFileInput(fichero);
            iSR = new InputStreamReader(fi);
            int linea;
            char[] inputBuffer = new char[READ_BLOCK_SIZE];
            while ((linea = iSR.read(inputBuffer)) > 0) {
                leido = leido + String.copyValueOf(inputBuffer, 0, linea);

            }
            texto.setText(leido);
            Toast.makeText(getBaseContext(), "Escrito", Toast.LENGTH_LONG).show();

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
