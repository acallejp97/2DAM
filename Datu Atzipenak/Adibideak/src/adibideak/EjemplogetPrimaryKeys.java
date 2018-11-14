package adibideak;

import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.ResultSet;
import java.sql.SQLException;

import konektatu.konexioa;

public class EjemplogetPrimaryKeys {

    public static void main(String[] args) throws ClassNotFoundException {
         try
          {
          	konexioa kon=new konexioa();
          	Connection conexion=kon.getKonekzioa(); 

          	DatabaseMetaData dbmd = conexion.getMetaData(); 
              ResultSet resul = null;
             
              System.out.println("CLAVE PRIMARIA TABLA DEPARTAMENTOS:");
              System.out.println("===================================");
              ResultSet pk = dbmd.getPrimaryKeys(null, "EJEMPLO", "DEPARTAMENTOS");
              String pkDep="", separador="";
              while (pk.next()) {
                     pkDep = pkDep + separador + 
                             pk.getString("COLUMN_NAME");//getString(4)
                     separador="+";
               }
              System.out.println("Clave Primaria: " + pkDep);


                
               conexion.close(); //Cerrar conexion                    
          } 
       catch (SQLException e) {e.printStackTrace();}        
        }
}