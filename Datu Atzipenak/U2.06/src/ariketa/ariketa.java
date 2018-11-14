package ariketa;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;
import konektatu.konexioa;

public class ariketa {
	static Scanner s=new Scanner(System.in);
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
        	 
        	konexioa kon = new konexioa();
            Connection conexion = kon.getKonekzioa();
            
           
            /*Class.forName("oracle.jdbc.driver.OracleDriver");
            Connection conexion = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:XE","ejemplo", "ejemplo");*/
            System.out.println("Sartu langile zenbakia:");
            	emp_no=s.nextInt();
            	Statement sententzia = conexion.createStatement();
            	ResultSet rs=sententzia.executeQuery("SELECT emp_no FROM empleados where emp_no="+emp_no);
            	if(rs.next()) {
            		System.out.println("langilea existitzen da");
            		ondo=false;
            	}
            	
            System.out.println("Sartu zure abizena:");
            	apellido=s.next();
            System.out.println("Sartu zure lanpostua:");
            	oficio=s.next();
            System.out.println("Sartu zure zuzendari zenbakia:");
            	dir=s.nextInt();
            	Statement sententzia2 = conexion.createStatement();
            	rs=sententzia.executeQuery("SELECT dir FROM empleados where dir="+dir);
            	if(rs.next()) {
            		System.out.println("zuzendaria existitzen da");
            	}else {
            		System.out.println("zuzendaria ez da eziztitzen");
            		ondo=false;
            	}
            System.out.println("Sartu zure soldata:");
            	salario=s.nextInt();
            	while(salario<700) {
            		System.out.println("Sartu balio positibo bat 700 baino handiagoa");
            		salario=s.nextInt();
            	}
            System.out.println("Sartu zure komisioa:");
            	comision=s.nextInt();
            	while(comision<0) {
            		System.out.println("Sartu balio positibo bat");
            		comision=s.nextInt();	
            	}
            System.out.println("Sartu zure departamentu zenbakia:");
            	dept_no=s.nextInt();
            	Statement sententzia3 = conexion.createStatement();
            	rs=sententzia.executeQuery("SELECT dept_no FROM empleados where dept_no="+dept_no);
            	if(rs.next()==false) {
            		System.out.println("departamentua ez da existitzen");
            		ondo=false;
            	}
                
            if(ondo) {
            String sql = "INSERT INTO empleados (emp_no, apellido, oficio, dir, fecha_alt, salario, comision, dept_no) "
                    + " VALUES ('"+emp_no+"','"+apellido+"','"+oficio+"','"+dir+"','"+fecha_alt+"','"+salario+"','"+comision+"','"+dept_no+"')";
                
          
            System.out.println(sql);
            Statement sententzia4 = conexion.createStatement();
            int filas=0;
            try {
              filas = sententzia.executeUpdate(sql.toString());
              System.out.println("Filas afectadas: " + filas);
            } catch (SQLException e) {
                //e.printStackTrace();
                   System.out.printf("HA OCURRIDO UNA EXCEPCIÓN:%n");
                   System.out.printf("Mensaje   : %s %n", e.getMessage());
                   System.out.printf("SQL estado: %s %n", e.getSQLState());
                   System.out.printf("Cód error : %s %n", e.getErrorCode());           
            }   
           

            sententzia.close();
            conexion.close();
            }else {            	
            	System.out.println("Txarto jarri duzu informazioa");
            }

        } catch (SQLException e) {
            e.printStackTrace();
        }

    }
}