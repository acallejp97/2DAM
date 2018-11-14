package adibideak;

import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

import konektatu.konexioa;

public class EjemplogetExportedKeys {

    public static void main(String[] args) throws ClassNotFoundException {
        try {

          	konexioa kon=new konexioa();
          	Connection conexion=kon.getKonekzioa();
            DatabaseMetaData dbmd = conexion.getMetaData();// Creamos
            // objeto DatabaseMetaData
            ResultSet resul = null;

            System.out.println("CLAVES ajenas que referencian a DEPARTAMENTOS:");
            System.out.println("==============================================");

            ResultSet fk = dbmd.getExportedKeys(null, "EJEMPLO", "DEPARTAMENTOS");

            while (fk.next()) {
                String fk_name = fk.getString("FKCOLUMN_NAME");
                String pk_name = fk.getString("PKCOLUMN_NAME");
                String pk_tablename = fk.getString("PKTABLE_NAME");
                String fk_tablename = fk.getString("FKTABLE_NAME");
                System.out.printf("Tabla PK: %s, Clave Primaria: %s %n", pk_tablename, pk_name);
                System.out.printf("Tabla FK: %s, Clave Ajena: %s %n", fk_tablename, fk_name);
            }

            conexion.close(); // Cerrar conexion
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }// fin de main

}