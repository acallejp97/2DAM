package konektatu;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class konektatu {  
   
    public static void main(String[] args) throws SQLException{
     
    	konexioa kon=new konexioa();
    	Connection conexion=kon.getKonekzioa();            
       String sql="SELECT * FROM departamentos";
       Statement sentencia = conexion.createStatement();   
       
       
       ResultSet rs = sentencia.executeQuery(sql);
            while (rs.next()) {
               System.out.printf("%d, %s, %s %n",
                       rs.getInt(1), rs.getString(2), rs.getString(3));
            }

            
        rs.close();
        sentencia.close();
        conexion.close();
    }//main
}//