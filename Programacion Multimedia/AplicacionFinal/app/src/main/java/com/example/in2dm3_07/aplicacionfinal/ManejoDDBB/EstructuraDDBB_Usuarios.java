package com.example.in2dm3_07.aplicacionfinal.ManejoDDBB;

/**
 * Created by Asier on 22/01/2018.
 */

public class EstructuraDDBB_Usuarios {

    private EstructuraDDBB_Usuarios() {
    }
    //creamos las columnas quu queremos que tenga nuestra tabla
    public static final String nombreTabla = "DatosClientes";
    public static final String columnaID = "ID";
    public static final String columnaNombre = "nombre";
    public static final String columnaApellido = "apellido";
    public static final String columnaTlf = "telefono";
    public static final String columnaPrestados = "Prestados";

    //la creamos
    public static final String SQL_CREATE_ENTRIES =
            "CREATE TABLE " + EstructuraDDBB_Usuarios.nombreTabla + " (" +
                    EstructuraDDBB_Usuarios.columnaID + " INTEGER PRIMARY KEY," +
                    EstructuraDDBB_Usuarios.columnaNombre + " TEXT," +
                    EstructuraDDBB_Usuarios.columnaApellido + " TEXT," +
                    EstructuraDDBB_Usuarios.columnaTlf + " INTEGER," +
                    EstructuraDDBB_Usuarios.columnaPrestados + " INTEGER)";

    //la borramos
    public static final String SQL_DELETE_ENTRIES =
            "DROP TABLE IF EXISTS " + EstructuraDDBB_Usuarios.nombreTabla;
}


