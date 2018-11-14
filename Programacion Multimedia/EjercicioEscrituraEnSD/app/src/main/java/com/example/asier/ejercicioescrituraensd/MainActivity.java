package com.example.asier.ejercicioescrituraensd;

import android.os.Environment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;

public class MainActivity extends AppCompatActivity {

    private EditText tbTexto;
    private String texto;
    private String archivo = "textfile.txt";
    private String ruta = "/MyFiles";
    private int READ_BLOCK_SIZE = 100;
    private String textoTotal;
    private int charRead;//Para saber cuantos caracteres hemos leido


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tbTexto = findViewById(R.id.tbTexto);
    }

    public void btnGuardarClicked(View view) {
        texto = tbTexto.getText().toString();

        try {
            //Buscar el directorio
            File sdCard = Environment.getExternalStorageDirectory();
            File directory = new File(sdCard.getAbsolutePath() + ruta);

            //Crear el directorio
            directory.mkdirs();

            //Buscar y/o crear el archivo
            File file = new File(directory, archivo);
            FileOutputStream fOut = new FileOutputStream(file);

            //Escribir en el fichero
            OutputStreamWriter osw = new OutputStreamWriter(fOut);
            osw.write(texto);
            osw.flush();
            osw.close();

            Toast.makeText(getBaseContext(), "Fichero guardado", Toast.LENGTH_LONG).show();

            //Limpiar el TextBox
            tbTexto.setText("");


        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void btnCargarClicked(View view) {
        try {
            File sdCard = Environment.getExternalStorageDirectory();
            File directory = new File(sdCard.getAbsolutePath() + ruta);
            File file = new File(directory, archivo);
            FileInputStream fIS = null;
            fIS = new FileInputStream(file);
            InputStreamReader isr = new InputStreamReader(fIS);

            //Leemos bloques de 100 caracteres ya que no sabemos el tamaño
            char[] inputBuffer = new char[READ_BLOCK_SIZE];
            textoTotal = "";
            while ((charRead = isr.read(inputBuffer)) > 0) {
                String readString = String.copyValueOf(inputBuffer, 0, charRead);
                textoTotal += readString;
            }
            tbTexto.setText(textoTotal);

            Toast.makeText(getBaseContext(), "Texto cargado", Toast.LENGTH_LONG).show();


        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

}


