package com.example.in2dm3_14.geoquiz;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.content.Intent;
import android.content.Context;

import android.os.Build;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.ViewAnimationUtils;
import android.widget.TextView;
import android.widget.Button;

import org.w3c.dom.Text;

public class Main2Activity extends AppCompatActivity {
    static final String NUM="numero";
    static final String trampa="trampa";
    static final String RES="respuesta";
    private TextView pregunta;
    private Button mostrar;
    private boolean respuesta;
    private boolean clicked;
    private boolean mostrada;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        pregunta= (TextView) findViewById(R.id.texto1);
        mostrar= (Button) findViewById(R.id.boton);
        if (savedInstanceState != null) {
            mostrada = savedInstanceState.getBoolean(trampa);
            setAnswerShownResult(mostrada);
            respuesta = savedInstanceState.getBoolean(RES);
            if(clicked)
            if (respuesta) pregunta.setText("Verdadero");
            else pregunta.setText("Falso");

       }
    }
    public void mostrarClick(View v){
        clicked=true;
        respuesta=getIntent().getBooleanExtra(NUM, false);
        mostrada=true;
        setAnswerShownResult(mostrada);
        if (respuesta) pregunta.setText("Verdadero");
        else pregunta.setText("Falso");
        if (Build.VERSION.SDK_INT> Build.VERSION_CODES.LOLLIPOP) {
            int cx = mostrar.getWidth() / 2;
            int cy = mostrar.getHeight() / 2;
            float radio = mostrar.getWidth();
            Animator anim = ViewAnimationUtils.createCircularReveal(mostrar, cx, cy, radio, 0);
            anim.addListener(new AnimatorListenerAdapter() {
                @Override
                public void onAnimationEnd(Animator animation) {
                    super.onAnimationEnd(animation);
                    pregunta.setVisibility(View.VISIBLE);
                    mostrar.setVisibility(View.INVISIBLE);
                }
            });
            anim.start();
        }
        else{
            pregunta.setVisibility(View.VISIBLE);
            mostrar.setVisibility(View.INVISIBLE);

        }
    }
    @Override
    public void onSaveInstanceState(Bundle savedInstanceState) {
        super.onSaveInstanceState(savedInstanceState);
        Log.d(NUM, "Cambia");
        savedInstanceState.putBoolean(trampa, mostrada);
        savedInstanceState.putBoolean(RES, respuesta);
    }
    public static Intent newIntent(Context packageContext, boolean answerIsTrue) {
        Intent i = new Intent(packageContext, Main2Activity.class);
        i.putExtra("", answerIsTrue);
        return i;
    }

    private void setAnswerShownResult(boolean isAnswerShown) {
        Intent data = new Intent();
        data.putExtra(" ", isAnswerShown);
        setResult(RESULT_OK, data);
    }
    public static boolean respuestaMostrada(Intent result){
        return result.getBooleanExtra(" ", false);
    }

}
