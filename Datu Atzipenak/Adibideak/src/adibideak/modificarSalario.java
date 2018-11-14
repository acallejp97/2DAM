package adibideak;

import java.sql.*;

import konektatu.konexioa;

public class modificarSalario {

 
 public static void main(String[] args) throws ClassNotFoundException {

 String dep = "10", subida ="100";
 
 
 try {
	 konexioa kon=new konexioa();
 	Connection conexion=kon.getKonekzioa();             
     
 
    String sql = String.format("UPDATE empleados SET salario = salario + %s WHERE dept_no = %s",
    subida, dep);    
 
     System.out.println(sql);

 Statement sentencia = conexion.createStatement();
 int filas = sentencia.executeUpdate(sql);
 System.out.printf("Empleados modificados: %d %n", filas);
 
 sentencia.close(); // Cerrar Statement
 conexion.close(); // Cerrar conexión

 } catch (SQLException e) {
 if (e.getErrorCode() == 1062)
 System.out.println("CLAVE PRIMARIA DUPLICADA");
 else 
 if (e.getErrorCode() == 1452)
 System.out.println("CLAVE AJENA "+ dep + " NO EXISTE");
 
 else {
 System.out.println("HA OCURRIDO UNA EXCEPCIÓN:");
 System.out.println("Mensaje:    " + e.getMessage());
 System.out.println("SQL estado: " + e.getSQLState());
 System.out.println("Cód error:  " + e.getErrorCode());
 }
 }

 }// fin de main
 }// fin de la clase