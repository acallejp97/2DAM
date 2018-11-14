package com.example.in2dm3_07;

import android.os.Bundle;
import android.widget.Toast;

/**
 * Created by in2dm3_15 on 11/12/2017.
 */

public class SecondActivity extends MainActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        Toast.makeText(this, "Notificacion recivida", Toast.LENGTH_SHORT).show();
    }


}
