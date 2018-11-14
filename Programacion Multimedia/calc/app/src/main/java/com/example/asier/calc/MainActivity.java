package com.example.asier.calc;


import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.graphics.drawable.Drawable;
import android.os.Build;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private int requestCode = 1;
    private int num = 0, salir = 0;
    private int colorFondo, colorBoton;

    private double total;

    private TextView texto;

    private LinearLayout f;

    private boolean todo = false;
    private boolean primera = false;
    private boolean[] botones;
    private boolean suma = false,
                    resta = false,
                    multi = false,
                    divi = false,
                    porcen = false,
                    raiz = false;

    Button btRaiz;
    Button btSuma;
    Button btResta;
    Button btMulti;
    Button btDivi;
    Button btPorcent;
    Button btPotenc;
    Button btIgual;
    Button btRaizX;

    private String fondo1 = "Boton";
    private String fondo2 = "Boton";
    private String res;

    @Override
    protected void onCreate(Bundle saveInstanceState) {
        super.onCreate(saveInstanceState);
        setContentView(R.layout.activity_main);
        texto = findViewById(R.id.textView);
        total = 0;

        f = (LinearLayout) findViewById(R.id.LinearLayoutM);
        btSuma = (Button) findViewById(R.id.btnSma);
        btResta = (Button) findViewById(R.id.btnResta);
        btMulti = (Button) findViewById(R.id.btnMult);
        btDivi = (Button) findViewById(R.id.btnDivi);
        btRaiz = (Button) findViewById(R.id.btnRaiz);
        btPorcent = (Button) findViewById(R.id.btnPorcentaje);
        btPotenc = (Button) findViewById(R.id.btnPotencia);
        btIgual = (Button) findViewById(R.id.btnIgual);
        btRaizX = (Button) findViewById(R.id.btnRaizX);


        if (saveInstanceState != null) {
            res = saveInstanceState.getString("res");
            total = saveInstanceState.getDouble("total");
            todo = saveInstanceState.getBoolean("todo");
            salir = saveInstanceState.getInt("salir");
            primera = saveInstanceState.getBoolean("primera");
            num = saveInstanceState.getInt("num");
            texto.setText(res + "");

            btSuma.setEnabled(saveInstanceState.getBoolean("Suma"));
            btResta.setEnabled(saveInstanceState.getBoolean("Resta"));
            btMulti.setEnabled(saveInstanceState.getBoolean("Multi"));
            btDivi.setEnabled(saveInstanceState.getBoolean("Divi"));
            btRaiz.setEnabled(saveInstanceState.getBoolean("Raiz"));
            btPorcent.setEnabled(saveInstanceState.getBoolean("Porcent"));

            fondo1=saveInstanceState.getString("colorFondo");
            fondo2=saveInstanceState.getString("colorBoton");
            colorFondo(fondo1,fondo2);
        }

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        super.onCreateOptionsMenu(menu);

        crearMenu(menu);

        return true;
    }

    private void crearMenu(Menu menu) {
        MenuItem item1 = menu.add(Menu.NONE, 1, Menu.NONE, "Ajustes");
    }

    @Override
    protected void onSaveInstanceState(Bundle saveInstanceState) {
        super.onSaveInstanceState(saveInstanceState);
        res = (String) texto.getText();
        saveInstanceState.putString("res", res);
        saveInstanceState.putDouble("total", total);
        saveInstanceState.putBoolean("primera", primera);
        saveInstanceState.putBoolean("todo", todo);
        saveInstanceState.putInt("salir", salir);
        saveInstanceState.putInt("num", num);

        saveInstanceState.putBoolean("Suma", btSuma.isEnabled());
        saveInstanceState.putBoolean("Resta", btResta.isEnabled());
        saveInstanceState.putBoolean("Multi", btMulti.isEnabled());
        saveInstanceState.putBoolean("Divi", btDivi.isEnabled());
        saveInstanceState.putBoolean("Raiz", btRaiz.isEnabled());
        saveInstanceState.putBoolean("Porcent", btPorcent.isEnabled());

        saveInstanceState.putString("colorFondo",fondo1);
        saveInstanceState.putString("colorBoton",fondo2);

    }


    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        super.onOptionsItemSelected(item);

        seleccionarOpcion(item);

        return true;
    }

    private void seleccionarOpcion(MenuItem item) {
        int id = item.getItemId();
        if (id == 1) {
            Intent Ajustes = new Intent(this, Ajustes.class);
            Ajustes.putExtra("btnSuma",btSuma.isEnabled());
            Ajustes.putExtra("btnResta",btResta.isEnabled());
            Ajustes.putExtra("btnMulti",btMulti.isEnabled());
            Ajustes.putExtra("btnDivi",btDivi.isEnabled());
            Ajustes.putExtra("btnPorcent",btPorcent.isEnabled());
            Ajustes.putExtra("btnRaiz",btRaiz.isEnabled());

            Ajustes.putExtra("colorFondo",fondo1);
            Ajustes.putExtra("colorBoton",fondo2);

            startActivityForResult(Ajustes, requestCode);
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        boolean[] botones = data.getBooleanArrayExtra("botones");
        deshabilitarBotones(botones);
        fondo1 = data.getStringExtra("fondo");
        fondo2 = data.getStringExtra("fondoBotones");
        colorFondo(fondo1, fondo2);

    }

    public void colorFondo(String fondooo, String botones) {
        colorBoton = 0;

        switch (fondooo) {
            case "Negro":
                f.setBackgroundColor(getResources().getColor(R.color.Negro));
                break;
            case "Blanco":
                f.setBackgroundColor(getResources().getColor(R.color.Blanco));
                break;
            case "Gris":
                f.setBackgroundColor(getResources().getColor(R.color.Gris));
                break;
            default:
                f.setBackgroundColor(0);

        }
        switch (botones) {
            case "Gris":
                colorBoton = getResources().getColor(R.color.Gris);
                break;
            case "Azul":
                colorBoton = getResources().getColor(R.color.Azul);
                break;
            case "Rosa":
                colorBoton = getResources().getColor(R.color.Rosa);
                break;
            default:
                colorBoton= 0;
        }

        btSuma.setBackgroundColor(colorBoton);
        btResta.setBackgroundColor(colorBoton);
        btMulti.setBackgroundColor(colorBoton);
        btDivi.setBackgroundColor(colorBoton);
        btRaiz.setBackgroundColor(colorBoton);
        btPorcent.setBackgroundColor(colorBoton);
        btPotenc.setBackgroundColor(colorBoton);
        btIgual.setBackgroundColor(colorBoton);
        btRaizX.setBackgroundColor(colorBoton);

    }

    public void deshabilitarBotones(boolean[] botones) {

        boolean suma = botones[0],
                resta = botones[1],
                multi = botones[2],
                divi = botones[3],
                porcen = botones[4],
                raiz = botones[5];

        btSuma.setEnabled(suma);
        btResta.setEnabled(resta);
        btMulti.setEnabled(multi);
        btDivi.setEnabled(divi);
        btRaiz.setEnabled(raiz);
        btPorcent.setEnabled(porcen);


    }

    @SuppressLint("ResourceType")
    public void boton1(View v) {


        Button b = findViewById(v.getId());

        if (texto.getText().equals("0")) {
            texto.setText("");
        }

        if (todo == true) {
            texto.setText("");
            todo = false;
            primera = false;
            num = 0;
            salir = 0;
            total = 0;
        }

        if (b.getText().equals("=")) {
            String numero = "";

            while (num < texto.getText().length()) {

                if (texto.getText().toString().substring(num, num + 1).equals("+") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = total + Double.parseDouble(numero);
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("-") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = total - Double.parseDouble(numero);
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("X") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("÷") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("%") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("√") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;

                } else if (texto.getText().toString().substring(num, num + 1).equals("^") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("€") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;
                } else if (texto.getText().toString().substring(num, num + 1).equals("$") && primera == false) {
                    while (salir == 0) {
                        num = num + 1;
                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }


                    }
                    total = 0;
                    numero = "";
                    primera = true;

                } else if (primera == false) {
                    while (salir == 0) {

                        if (num >= texto.getText().length()) {
                            salir = 1;
                        } else if (comparator(texto, num)) {
                            salir = 1;
                        } else {
                            numero = numero + texto.getText().toString().substring(num, num + 1);
                        }

                        num = num + 1;
                    }
                    num = num - 1;

                    total = total + Double.parseDouble(numero);
                    numero = "";
                    primera = true;

                }
//------------------------------------------------------------------------------------------------------------------------//
                salir = 0;
                if (num < texto.getText().length()) {
                    if (texto.getText().toString().substring(num, num + 1).equals("+") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }


                        }
                        total = total + Double.parseDouble(numero);
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("-") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }

                        }
                        total = total - Double.parseDouble(numero);
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("%") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }

                        }
                        total = total * Double.parseDouble(numero) / 100;
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("X") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }


                        }
                        total = total * Double.parseDouble(numero);
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("÷") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }
                        }
                        total = total / Double.parseDouble(numero);
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("√") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }
                        }
                        if (total == 0)
                            total = 1;
                        total = (total * Math.sqrt(Double.parseDouble(numero)));
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("$") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }
                        }
                        if (total == 0)
                            total = 1;
                        total = (total * 1.2);
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("€") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }
                        }
                        if (total == 0)
                            total = 1;
                        total = (total / 1.2);
                        numero = "";
                        num = num - 1;

                    } else if (texto.getText().toString().substring(num, num + 1).equals("^") && primera == true) {
                        while (salir == 0) {
                            num = num + 1;
                            if (num >= texto.getText().length()) {
                                salir = 1;
                            } else if (comparator(texto, num)) {
                                salir = 1;
                            } else {
                                numero = numero + texto.getText().toString().substring(num, num + 1);
                            }
                        }
                        if (total == 0)
                            total = 1;
                        total = (Math.pow(total, Double.parseDouble(numero)));
                        numero = "";
                        num = num - 1;

                    }
                    todo = true;
                }
                num = num + 1;

            }

            primera = false;
            texto.setText("" + total);


        } else {
            if (b.getText().equals("←")) {
                if (texto.getText().length() > 1) {
                    texto.setText(texto.getText().toString().substring(0, texto.getText().length() - 1));
                } else {
                    texto.setText("");
                }

            } else if (b.getText().equals("CE")) {
                texto.setText("");
                todo = false;
                primera = false;
                num = 0;
                salir = 0;
                total = 0;
            } else {
                texto.setText(texto.getText().toString() + b.getText());
            }

        }

    }

    public boolean comparator(TextView ed, int num) {
        boolean b = false;
        if (ed.getText().toString().substring(num, num + 1).equals("+") ||
                ed.getText().toString().substring(num, num + 1).equals("-") ||
                ed.getText().toString().substring(num, num + 1).equals("X") ||
                ed.getText().toString().substring(num, num + 1).equals("÷") ||
                ed.getText().toString().substring(num, num + 1).equals("$") ||
                ed.getText().toString().substring(num, num + 1).equals("€") ||
                ed.getText().toString().substring(num, num + 1).equals("%") ||
                ed.getText().toString().substring(num, num + 1).equals("^") ||
                ed.getText().toString().substring(num, num + 1).equals("√")) {
            b = true;
        }
        return b;
    }

}

