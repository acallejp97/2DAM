package com.example.asier.calc;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.RadioButton;
import android.widget.RadioGroup;

/**
 * Created by Asier on 19/11/2017.
 */

public class Ajustes extends AppCompatActivity {

    private CheckBox cbResta;
    private CheckBox cbSuma;
    private CheckBox cbMulti;
    private CheckBox cbDivi;
    private CheckBox cbPorcent;
    private CheckBox cbRaiz;

    RadioButton ra;
    RadioButton rb;
    RadioButton rc;
    RadioButton rd;
    RadioButton re;
    RadioButton rf;

    private String fondo1, fondo2;
    private boolean suma = true,
            resta = true,
            multi = true,
            divi = true,
            porcen = true,
            raiz = true;
    private boolean[] botones;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.ajustes);

        ra = (RadioButton) findViewById(R.id.rbNegro);
        rb = (RadioButton) findViewById(R.id.rbBlanco);
        rc = (RadioButton) findViewById(R.id.rbGris);
        rd = (RadioButton) findViewById(R.id.rbGris2);
        re = (RadioButton) findViewById(R.id.rbAzul);
        rf = (RadioButton) findViewById(R.id.rbRosa);

        cbRaiz = (CheckBox) findViewById(R.id.cbRaiz);
        cbSuma = (CheckBox) findViewById(R.id.cbSuma);
        cbResta = (CheckBox) findViewById(R.id.cbResta);
        cbMulti = (CheckBox) findViewById(R.id.cbMulti);
        cbDivi = (CheckBox) findViewById(R.id.cbDivi);
        cbPorcent = (CheckBox) findViewById(R.id.cbPorcent);

        if (savedInstanceState != null) {
            ra.setSelected(savedInstanceState.getBoolean("Negro"));
            rb.setSelected(savedInstanceState.getBoolean("Blanco"));
            rc.setSelected(savedInstanceState.getBoolean("Gris"));
            rd.setSelected(savedInstanceState.getBoolean("Gris2"));
            re.setSelected(savedInstanceState.getBoolean("Azul"));
            rf.setSelected(savedInstanceState.getBoolean("Rosa"));

            cbSuma.setChecked(savedInstanceState.getBoolean("Suma"));
            cbResta.setChecked(savedInstanceState.getBoolean("Resta"));
            cbMulti.setChecked(savedInstanceState.getBoolean("Multi"));
            cbDivi.setChecked(savedInstanceState.getBoolean("Divi"));
            cbRaiz.setChecked(savedInstanceState.getBoolean("Raiz"));
            cbPorcent.setChecked(savedInstanceState.getBoolean("Porcent"));

        } else {
            cbSuma.setChecked(!getIntent().getBooleanExtra("btnSuma", suma));
            cbResta.setChecked(!getIntent().getBooleanExtra("btnResta", resta));
            cbMulti.setChecked(!getIntent().getBooleanExtra("btnMulti", multi));
            cbDivi.setChecked(!getIntent().getBooleanExtra("btnDivi", divi));
            cbRaiz.setChecked(!getIntent().getBooleanExtra("btnRaiz", raiz));
            cbPorcent.setChecked(!getIntent().getBooleanExtra("btnPorcent", porcen));

            fondo1 = getIntent().getStringExtra("colorFondo");
            fondo2 = getIntent().getStringExtra("colorBoton");

            habilitar(fondo1, fondo2);
        }
        cb(cbRaiz);
        btn(ra);
    }

    public void habilitar(String fondo, String colores) {

        switch (fondo) {
            case "Negro":
                ra.setChecked(true);
                break;
            case "Blanco":
                rb.setChecked(true);
                break;
            case "Gris":
                rc.setChecked(true);
                break;
            default:
        }
        switch (colores) {
            case "Azul":
                re.setChecked(true);
                break;
            case "Rosa":
                rf.setChecked(true);
                break;
            case "Gris":
                rd.setChecked(true);
                break;
            default:
        }
    }

    @Override
    protected void onSaveInstanceState(Bundle saveInstanceState) {
        super.onSaveInstanceState(saveInstanceState);

        saveInstanceState.putBoolean("Negro", ra.isChecked());
        saveInstanceState.putBoolean("Blanco", rb.isChecked());
        saveInstanceState.putBoolean("Gris", rc.isChecked());
        saveInstanceState.putBoolean("Gris2", rd.isChecked());
        saveInstanceState.putBoolean("Azul", re.isChecked());
        saveInstanceState.putBoolean("Rosa", rf.isChecked());

        saveInstanceState.putBoolean("Suma", cbSuma.isChecked());
        saveInstanceState.putBoolean("Resta", cbResta.isChecked());
        saveInstanceState.putBoolean("Multi", cbMulti.isChecked());
        saveInstanceState.putBoolean("Divi", cbDivi.isChecked());
        saveInstanceState.putBoolean("Raiz", cbRaiz.isChecked());
        saveInstanceState.putBoolean("Porcent", cbPorcent.isChecked());
    }

    @Override
    public void onBackPressed() {
        boolean[] botones = {suma, resta, multi, divi, porcen, raiz};
        Intent i1 = getIntent();
        i1.putExtra("botones", botones);
        i1.putExtra("fondo", fondo1);
        i1.putExtra("fondoBotones", fondo2);
        setResult(RESULT_OK, i1);
        super.onBackPressed();
    }

    public void cb(View v) {

        if (cbRaiz.isChecked() == true) {
            raiz = false;
        } else {
            raiz = true;
        }

        if (cbSuma.isChecked() == true) {
            suma = false;
        } else {
            suma = true;
        }

        if (cbResta.isChecked() == true) {
            resta = false;
        } else {
            resta = true;
        }

        if (cbMulti.isChecked() == true) {
            multi = false;
        } else {
            multi = true;
        }

        if (cbDivi.isChecked() == true) {
            divi = false;
        } else {
            divi = true;
        }

        if (cbPorcent.isChecked() == true) {
            porcen = false;
        } else {
            porcen = true;
        }

    }

    public void btn(View v) {

        if (ra.isChecked()) {
            fondo1 = "Negro";
        } else if (rb.isChecked()) {
            fondo1 = "Blanco";
        } else if (rc.isChecked()) {
            fondo1 = "Gris";

        }
        if (rd.isChecked()) {
            fondo2 = "Gris";
        } else if (re.isChecked()) {
            fondo2 = "Azul";
        } else if (rf.isChecked()) {
            fondo2 = "Rosa";
        }
    }

}


