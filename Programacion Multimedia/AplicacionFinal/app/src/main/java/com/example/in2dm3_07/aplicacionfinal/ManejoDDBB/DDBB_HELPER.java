package com.example.in2dm3_07.aplicacionfinal.ManejoDDBB;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Asier on 21/01/2018.
 */
//Con esto manejamos la base de datos que
public class DDBB_HELPER extends SQLiteOpenHelper {

    public static final int DATABASE_VERSION = 1;
    public static final String nombreBBDD = "DDBB_Biblioteca.db";

    public DDBB_HELPER(Context context) {

        super(context, nombreBBDD, null, DATABASE_VERSION);
    }

    public void onCreate(SQLiteDatabase db) {
        db.execSQL(EstructuraDDBB_Usuarios.SQL_CREATE_ENTRIES);
        db.execSQL(EstructuraDDBB_Libros.SQL_CREATE_ENTRIES);
    }

    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL(EstructuraDDBB_Usuarios.SQL_DELETE_ENTRIES);
        db.execSQL(EstructuraDDBB_Libros.SQL_DELETE_ENTRIES);
        onCreate(db);
    }

    public void onDowngrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        onUpgrade(db, oldVersion, newVersion);
    }
}
