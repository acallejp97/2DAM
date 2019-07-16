package com.example.in2dm3_07.aplicacionfinal.ManejoDDBB;

/**
 * Created by in2dm3_07 on 23/01/2018.
 */
//Esta clase es exactamente igual que la de usuarios
public class EstructuraDDBB_Libros {

    private EstructuraDDBB_Libros() {
    }

    public static final String nombreTabla = "DatosLibros";
    public static final String columnaISBN = "ISBN";
    public static final String columnaTitulo = "Titulo";
    public static final String columnaAutor = "Autor";
    public static final String columnaEditorial = "Editorial";
    public static final String columnaPrestado = "PrestadoA";

    public static final String SQL_CREATE_ENTRIES =
            "CREATE TABLE " + EstructuraDDBB_Libros.nombreTabla + " (" +
                    EstructuraDDBB_Libros.columnaISBN + " INTEGER PRIMARY KEY," +
                    EstructuraDDBB_Libros.columnaTitulo + " TEXT," +
                    EstructuraDDBB_Libros.columnaAutor + " TEXT," +
                    EstructuraDDBB_Libros.columnaEditorial + " TEXT," +
                    EstructuraDDBB_Libros.columnaPrestado + " TEXT)";

    public static final String SQL_DELETE_ENTRIES =
            "DROP TABLE IF EXISTS " + EstructuraDDBB_Libros.nombreTabla;
}