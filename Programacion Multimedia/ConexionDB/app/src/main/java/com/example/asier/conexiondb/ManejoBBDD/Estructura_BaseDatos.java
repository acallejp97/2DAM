package com.example.asier.conexiondb.ManejoBBDD;

/**
 * Created by Asier on 21/01/2018.
 */

public class Estructura_BaseDatos {

    // To prevent someone from accidentally instantiating the contract class,
    // make the constructor private.
    private Estructura_BaseDatos() {

    }

    /* Inner class that defines the table contents */
        public static final String nombreTabla= "datosPersonales";
        public static final String columnaID= "ID";
        public static final String columnaNombre= "nombre";
        public static final String columnaEmail= "email";



    public static final String SQL_CREATE_ENTRIES =
            "CREATE TABLE " + Estructura_BaseDatos.nombreTabla+ " (" +
                    Estructura_BaseDatos.columnaID+ " INTEGER PRIMARY KEY," +
                    Estructura_BaseDatos.columnaNombre+ " TEXT," +
                    Estructura_BaseDatos.columnaEmail+ " TEXT)";

    public static final String SQL_DELETE_ENTRIES =
            "DROP TABLE IF EXISTS " + Estructura_BaseDatos.nombreTabla;


}
