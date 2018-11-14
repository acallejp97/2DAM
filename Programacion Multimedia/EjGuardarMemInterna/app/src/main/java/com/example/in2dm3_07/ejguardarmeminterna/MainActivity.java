package com.example.in2dm3_07.ejguardarmeminterna;

import android.app.Activity;
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

public class MainActivity extends Activity {
    EditText editText;
    //cte para bloque de lectura
    static final int READ_BLOCK_SIZE = 100;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        editText = (EditText) findViewById(R.id.editText);
    }

    public void onClickGuardar(View view) {
        String texto = editText.getText().toString();
        FileOutputStream fileOutputStream;
        OutputStreamWriter outputStreamWriter = null;
        try {
            fileOutputStream = openFileOutput("miFichero.txt", MODE_APPEND);
            outputStreamWriter = new OutputStreamWriter(fileOutputStream);
            outputStreamWriter.write(texto);
            outputStreamWriter.flush();
            Toast.makeText(getBaseContext(), "Fichero guardado correctamente", Toast.LENGTH_LONG).show();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                outputStreamWriter.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    public void onClickCargar(View view) {
        FileInputStream fileInputStream;
        InputStreamReader inputStreamReader = null;
        try {
            fileInputStream = openFileInput("miFichero.txt");
            inputStreamReader = new InputStreamReader(fileInputStream);
            int carLeidos;
            char[] inputBuffer = new char[READ_BLOCK_SIZE];
            String texto = "";
            while ((carLeidos = inputStreamReader.read(inputBuffer)) > 0) {
                String leido = String.copyValueOf(inputBuffer, 0, carLeidos);
                texto += leido;
            }
            editText.setText(texto);
            Toast.makeText(getBaseContext(), "Ficher cargado correctamente", Toast.LENGTH_LONG).show();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                inputStreamReader.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}