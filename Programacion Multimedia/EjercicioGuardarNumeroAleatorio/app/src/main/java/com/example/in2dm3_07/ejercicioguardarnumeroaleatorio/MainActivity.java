package com.example.in2dm3_07.ejercicioguardarnumeroaleatorio;

import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private int randomNumber;
    private TextView tvBackup;
    private TextView tvRandom;
    private int comparar;
    private SharedPreferences guardado;

    //Declarar las claves que vamos usar para que no haya errores
    private String Random = "Random";
    private String guardar = "SAVE";
    private String Backup = "Backup";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tvBackup = findViewById(R.id.tvBackup);
        tvRandom = findViewById(R.id.tvRandom);

        //Sacar variables
        guardado = getSharedPreferences(guardar, MODE_PRIVATE);
        tvRandom.setText(String.valueOf((guardado.getInt(Random, 0))));
        tvBackup.setText(String.valueOf(guardado.getInt(Backup, 0)));

    }

    public void btnRandomClicked(View view) {
        randomNumber = (int) (Math.random() * 500);
        comparar = Integer.parseInt((String) tvBackup.getText());
        tvRandom.setText(String.valueOf(randomNumber));

        // Guardar los datos
        SharedPreferences.Editor edit = guardado.edit();
        //Puede ser tanto int como String como lo que quieras
        edit.putInt(Random, randomNumber);

        if (randomNumber > comparar) {
            tvBackup.setText(String.valueOf(randomNumber));

            edit.putInt(Backup, randomNumber);
            ;
        }
        //Importante para guardar los cambios
        edit.commit();

    }

    public void btnResetClicked(View view) {
        tvRandom.setText("0");
        tvBackup.setText("0");

        //Resetear el backup
        SharedPreferences.Editor edit = guardado.edit();
        edit.putInt(Random, 0);
        edit.putInt(Backup, 0);
        ;
        edit.commit();
    }
}
