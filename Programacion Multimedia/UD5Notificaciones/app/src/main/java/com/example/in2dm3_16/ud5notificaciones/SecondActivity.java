package com.example.in2dm3_16.ud5notificaciones;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Toast;

public class SecondActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        Toast.makeText(this, "Notificacion Recibida", Toast.LENGTH_SHORT).show();
        finish();
    }
}
