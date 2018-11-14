package com.example.in2dm3_14.geoquiz;

/**
 * Created by in2dm3_14 on 29/09/2017.
 */
public class Question {
    private int id;
    private boolean respuesta;
    public int getId() {
        return id;
    }


    public boolean isRespuesta() {
        return respuesta;
    }



    public Question(int id, boolean respuesta){
       this.id=id;
        this.respuesta=respuesta;
   }
}
