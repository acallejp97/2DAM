package ariketa2_6;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class emple_sortu {
	static Scanner teclado=new Scanner(System.in);
	public static void main(String[] args) throws ClassNotFoundException {
        try {
        	 int emp_no;
        	 String apellido;
        	 String oficio;
        	 int dir;
        	 int salario;
        	 int comision;
        	 int dept_no;
        	 boolean ondo=true;
        	 java.sql.Date fecha_alt= new java.sql.Date(System.currentTimeMillis());
        	 
        	Konexioa kon = new Konexioa();
            Connection conexion = kon.getKonekzioa();
            
           
            /*Class.forName("oracle.jdbc.driver.OracleDriver");
            Connection conexion = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:XE","ejemplo", "ejemplo");*/
            System.out.println("Sartu langile zenbakia:");
            	emp_no=teclado.nextInt();
            	Statement sentencia = conexion.createStatement();
            	ResultSet rs=sentencia.executeQuery("SELECT emp_no FROM empleados where emp_no="+emp_no);
            	if(rs.next()) {
            		System.out.println("langilea existitzen da");
            		ondo=false;
            	}
            	
            System.out.println("Sartu zure abizena:");
            	apellido=teclado.next();
            System.out.println("Sartu zure lanpostua:");
            	oficio=teclado.next();
            System.out.println("Sartu zure zuzendaria:");
            	dir=teclado.nextInt();
            	Statement sentencia2 = conexion.createStatement();
            	rs=sentencia.executeQuery("SELECT dir FROM empleados where dir="+dir);
            	if(rs.next()) {
            		System.out.println("zuzendaria existitzen da");
            	}else {
            		System.out.println("zuzendatia ez da eziztitzen");
            		ondo=false;
            	}
            System.out.println("Sartu zure soldata:");
            	salario=teclado.nextInt();
            System.out.println("Sartu zure komisioa:");
            	comision=teclado.nextInt();
            
            System.out.println("Sartu zure departamentu zenbakia:");
            	dept_no=teclado.nextInt();
            	Statement sentencia3 = conexion.createStatement();
            	rs=sentencia.executeQuery("SELECT dept_no FROM empleados where dept_no="+dept_no);
            	if(rs.next()) {
            		System.out.println("departamentua existitzen da");
            		ondo=false;
            	}
           
            
           
            //construir orden INSERT     
            if(ondo) {
            String sql = "INSERT INTO empleados (emp_no, apellido, oficio, dir, fecha_alt, salario, comision, dept_no) "
                    + " VALUES ('"+emp_no+"','"+apellido+"','"+oficio+"','"+dir+"','"+fecha_alt+"','"+salario+"','"+comision+"','"+dept_no+"')";
                   
           
            System.out.println(sql);

           
            //https://docs.oracle.com/javase/7/docs/api/java/util/Formatter.html
           
            System.out.println(sql);
            Statement sentencia4 = conexion.createStatement();
            int filas=0;
            try {
              filas = sentencia.executeUpdate(sql.toString());
              System.out.println("Filas afectadas: " + filas);
            } catch (SQLException e) {
                //e.printStackTrace();
                   System.out.printf("HA OCURRIDO UNA EXCEPCIÓN:%n");
                   System.out.printf("Mensaje   : %s %n", e.getMessage());
                   System.out.printf("SQL estado: %s %n", e.getSQLState());
                   System.out.printf("Cód error : %s %n", e.getErrorCode());           
            }
           
           

            sentencia.close(); // Cerrar Statement
            conexion.close(); // Cerrar conexión
            }else {
            	
            	System.out.println("Txo txarto jarri duzu informazioa");
            }

        } catch (SQLException e) {
            e.printStackTrace();
        }

    }
}
