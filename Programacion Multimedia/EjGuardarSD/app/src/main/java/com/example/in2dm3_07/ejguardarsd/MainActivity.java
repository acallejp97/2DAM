package com.example.in2dm3_07.ejguardarsd;

import android.os.Environment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class MainActivity extends AppCompatActivity {

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
        String str = textBox.getText().toString();
        try {
            //---Almacenamiento en SD Card ---
            File sdCard = Environment.getExternalStorageDirectory();
            File directory = new File(sdCard.getAbsolutePath() + "/MyFiles");
            directory.mkdirs();
            File file = new File(directory, "textfile.txt");
            FileOutputStream fOut = new FileOutputStream(file);
            /*		para almacenar en memoria interna
			FileOutputStream fOut =
					openFileOutput("textfile.txt",
							MODE_WORLD_READABLE);
			*/


            OutputStreamWriter osw = new
                    OutputStreamWriter(fOut);
            //---escribir la cadena en el archivo---
            osw.write(str);
            osw.flush();
            osw.close();
            //---mostrar mensaje de archivo guardado---
            Toast.makeText(this, "", Toast.LENGTH_SHORT).show();.makeText(getBaseContext(),
                    "Fichero guardado correctamente!",
                    Toast.LENGTH_SHORT).show();
            //---borrar el editext---
            textBox.setText("");
        } catch (IOException ioe) {
            ioe.printStackTrace();
        }
    }

    public void onClickCargar(View view) {
        try {

            //--- leer de tarjeta SD ---
            File sdCard = Environment.getExternalStorageDirectory();
            File directory = new File(sdCard.getAbsolutePath() +
                    "/MyFiles");
            File file = new File(directory, "textfile.txt");
            FileInputStream fIn = new FileInputStream(file);
            InputStreamReader isr = new InputStreamReader(fIn);
            /* para leer de memoria interna
			FileInputStream fIn =
					openFileInput("textfile.txt");
			InputStreamReader isr = new
					InputStreamReader(fIn);
            */

//no sabemos el tamaño del fichero, leemos e bloques de //100 caracteres
            char[] inputBuffer = new char[READ_BLOCK_SIZE];
            String s = "";
            int charRead;  //número de caracteres leidos
            while ((charRead = isr.read(inputBuffer)) > 0) {
                //---convertir en cadena---
                String readString =
                        String.copyValueOf(inputBuffer, 0,
                                charRead);
                s += readString;
                inputBuffer = new char[READ_BLOCK_SIZE];
            }
            //---establecer el EditText con el texto leido
            // read---
            textBox.setText(s);
            Toast.makeText(getBaseContext(),
                    "Fichero cargado correctamente!",
                    Toast.LENGTH_SHORT).show();
        } catch (IOException ioe) {
            ioe.printStackTrace();
        }
    }
}