package com.example.in2dm3_14.geoquiz;

import android.app.Activity;
import android.content.Intent;
import android.os.Build;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    static final String NUM = "numero";
    static final String trampa = "trampa";
    private final int code = 1;
    public static final String TAG = "MainActivity";
    private int REQUEST_CODE_CHEAT = 0;
    private Button mTrueButton;
    private Button mFalseButton;
    private TextView texto;
    private TextView version;
    private boolean mostrada = false;

    public ArrayList<Question> preguntas = new ArrayList<Question>(5);
    public boolean[] trampas= new boolean[5];
    int numero = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if (savedInstanceState != null) {
            numero = savedInstanceState.getInt(NUM);
            trampas = savedInstanceState.getBooleanArray(trampa);
        }
        Log.d(TAG, "onCreate: ");
        Question pregunta1 = new Question(R.string.pregunta1, true);
        Question pregunta2 = new Question(R.string.pregunta2, false);
        Question pregunta3 = new Question(R.string.pregunta3, true);
        Question pregunta4 = new Question(R.string.pregunta4, true);
        Question pregunta5 = new Question(R.string.pregunta5, false);
        preguntas.add(pregunta1);
        preguntas.add(pregunta2);
        preguntas.add(pregunta3);
        preguntas.add(pregunta4);
        preguntas.add(pregunta5);
        setContentView(R.layout.quizlayout);
        texto = (TextView) findViewById(R.id.texto1);
        texto.setText(preguntas.get(numero).getId());
        version= (TextView) findViewById(R.id.version);
        version.setText("API level:"+Build.VERSION.SDK_INT);
        mTrueButton = (Button) findViewById(R.id.button);
        mFalseButton = (Button) findViewById(R.id.button2);

    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (resultCode != Activity.RESULT_OK) return;
        if (requestCode == REQUEST_CODE_CHEAT) {
            if (data == null){ return;}
            mostrada = Main2Activity.respuestaMostrada(data);
            trampas[numero]=mostrada;
        }
    }

    @Override
    public void onSaveInstanceState(Bundle savedInstanceState) {
        super.onSaveInstanceState(savedInstanceState);
        Log.d(TAG, "Cambia");
        savedInstanceState.putInt(NUM, numero);
        savedInstanceState.putBooleanArray(trampa, trampas);

    }

    public void cheatClick(View v) {
        Intent i = new Intent(MainActivity.this, Main2Activity.class);
        i.putExtra(NUM, preguntas.get(numero).isRespuesta());
        startActivityForResult(i, REQUEST_CODE_CHEAT);
    }

    @Override
    public void startActivityForResult(Intent intent, int requestCode) {
        intent.putExtra("requestCode", requestCode);
        super.startActivityForResult(intent, requestCode);
    }


    public void textClick(View v) {
        numero++;
        if (preguntas.size() == numero) {
            numero = 0;
        }
        mostrada=false;
        texto.setText(preguntas.get(numero).getId());
    }
    public void nextClick(View v) {
        numero++;
        if (preguntas.size() == numero) {
            numero = 0;
        }
        mostrada=false;
        texto.setText(preguntas.get(numero).getId());
    }
    public void previousClick(View v) {
        if (0 == numero) {
            numero = preguntas.size();
        }
        mostrada=false;
        numero--;
        texto.setText(preguntas.get(numero).getId());

    }

    @Override
    protected void onStart() {
        super.onStart();
        Log.d(TAG, "OnStart");
    }

    @Override
    protected void onStop() {
        Log.d(TAG, "onStop");
        super.onStop();
    }

    @Override
    protected void onDestroy() {
        Log.d(TAG, "onDestroy");
        super.onDestroy();
    }

    @Override
    protected void onPause() {
        Log.d(TAG, "onPause");
        super.onPause();
    }

    @Override
    protected void onResume() {
        Log.d(TAG, "onResume");
        super.onResume();
    }



    public void falsoClick(View v) {

        if (trampas[numero]) Toast.makeText(getBaseContext(), "trampa", Toast.LENGTH_SHORT).show();
        else {
            if (preguntas.get(numero).isRespuesta()) {
                Toast.makeText(getBaseContext(), R.string.mal, Toast.LENGTH_SHORT).show();
            } else {
                Toast.makeText(getBaseContext(), R.string.bien, Toast.LENGTH_SHORT).show();
            }
        }
    }

    public void verdaderoClick(View v) {
        if (trampas[numero]) Toast.makeText(getBaseContext(), "trampa", Toast.LENGTH_SHORT).show();
        else {
            if (preguntas.get(numero).isRespuesta()) {
                Toast.makeText(getBaseContext(), R.string.bien, Toast.LENGTH_SHORT).show();
            } else {
                Toast.makeText(getBaseContext(), R.string.mal, Toast.LENGTH_SHORT).show();
            }
        }
    }
}
