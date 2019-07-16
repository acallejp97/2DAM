package com.example.in2dm3_07.aplicacionfinal.ManejoDDBB;

/**
 * Created by Asier on 22/01/2018.
 */

public class EstructuraDDBB {

    private EstructuraDDBB() {}

    public static final String nombreTabla= "DatosClientes";
    public static final String columnaID= "ID";
    public static final String columnaNombre= "nombre";
    public static final String columnaApellido= "apellido";
    public static final String columnaTlf= "telefono";

    public static final String SQL_CREATE_ENTRIES =
            "CREATE TABLE " + EstructuraDDBB.nombreTabla+ " (" +
                    EstructuraDDBB.columnaID+ " INTEGER PRIMARY KEY," +
                    EstructuraDDBB.columnaNombre+ " TEXT," +
                    EstructuraDDBB.columnaApellido+ " TEXT," +
                    EstructuraDDBB.columnaTlf+ " INTEGER)";

    public static final String SQL_DELETE_ENTRIES =
            "DROP TABLE IF EXISTS " + EstructuraDDBB.nombreTabla;
}


