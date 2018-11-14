package com.example.in2dm3_07.ejguardarpreferencias;

import android.os.Bundle;
import android.app.Activity;
import android.content.SharedPreferences;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.SeekBar.OnSeekBarChangeListener;
import android.widget.Toast;

public class MainActivity extends Activity {

    private SharedPreferences prefs;
    //para dar un nombre al archivo donde se guardaran las preferencias
    private String nombrePref="MiPref";
    private EditText editText;
    private SeekBar seekBar;
    private Button btn;

    //constantes
    private static final String TAM_FUENTE_KEY="tamfuente";
    private static final String VALOR_TEXTO_KEY="valortexto";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //relacionar las variables con las vistas
        editText=(EditText) findViewById(R.id.editTex1);
        seekBar=(SeekBar) findViewById(R.id.seekBar1);
        btn=(Button) findViewById(R.id.btnSalvar);


        //cargar el objeto sharedPreferences desde el archivo
        prefs=getSharedPreferences(nombrePref, MODE_PRIVATE);

        //configurar el tamaño de la fuente a los valores salvados
        float fontSize=prefs.getFloat(TAM_FUENTE_KEY, 12);//12-->valor por defecto
        //init la seekbar y editText
        seekBar.setProgress((int)fontSize);

        editText.setText(prefs.getString(VALOR_TEXTO_KEY, ""));
        editText.setTextSize(seekBar.getProgress());

        //programar la seekBar para que cambia el tamaño del texto
        seekBar.setOnSeekBarChangeListener(new OnSeekBarChangeListener() {
            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {
            }
            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {
            }
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress,
                                          boolean fromUser) {
                // ---cambiar el tamaño fuente del EditText---
                editText.setTextSize(progress);
            }
        });

    }

    public void btnSaveOnClick(View view){

        //obtener el objeto getSharedPreferences indicando el nombre del archivo donde se guardaran las preferencias
        // modo privado--> sólo puede acceder esta aplicación a ese ficheros

        prefs=getSharedPreferences(nombrePref, MODE_PRIVATE);
        SharedPreferences.Editor editor=prefs.edit();
        //salvar los valores en la vista Edittext a preferencias
        editor.putFloat(TAM_FUENTE_KEY, seekBar.getProgress());
        editor.putString(VALOR_TEXTO_KEY, editText.getText().toString());

        //salvar los valores
        editor.commit();

        //mostrar mensaje de archivo salvado
        Toast.makeText(getBaseContext(), "Tamaño fuente salvado correctamente", Toast.LENGTH_LONG).show();

    }

}
