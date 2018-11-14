package ariketa;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.DecimalFormat;
import java.util.InputMismatchException;
import java.util.Scanner;


import konektatu.konexioa;

public class ariketa {

	static Scanner s = new Scanner(System.in);

	public static void main(String[] args) throws SQLException {
		// TODO Auto-generated method stub
		double AVGSoldata, soldata=0;
		int dep=0;
		String apellido="", oficio="";
		try {
		do {
		System.out.println("Ze departamentu ikusi nahi duzu?[10, 20, 30]");
		dep = s.nextInt();
		}while(dep != 10 && dep !=20 && dep !=30);
		}catch (InputMismatchException e) {
			System.out.println("Departamentua zenbakia izan behar da");
			
		}
		
		konexioa kon = new konexioa();
        Connection conexion = kon.getKonekzioa();
        
        
        Statement sentenciaDEP = conexion.createStatement();
    	ResultSet rs = sentenciaDEP.executeQuery("SELECT apellido, salario, oficio FROM empleados where dept_no = "+dep);
    	
    	System.out.println("Apellido" + "\t" + "Salario" + "\t" + "\t" + "Oficio");
    	
    	while(rs.next()) {
    		apellido=rs.getString(1);
    		soldata = rs.getDouble(2);
    		DecimalFormat formatua= new DecimalFormat("##,##0.00");
    		String SoldataFormateatua =formatua.format(soldata);
    		oficio = rs.getString(3);
    		System.out.println(apellido + "\t" + "\t" + SoldataFormateatua + "\t" + oficio);
    	}
    	
    	Statement sentenciaAVG = conexion.createStatement();
    	rs = sentenciaAVG.executeQuery("SELECT AVG(salario), COUNT(*) FROM empleados where dept_no = "+dep);
    	while(rs.next()) {
    		int kontadorea;
    		
    		AVGSoldata = rs.getDouble(1);
    		kontadorea= rs.getInt(2);
    		DecimalFormat formatua= new DecimalFormat("##,##0.00");
    		String AVGFormateatua = formatua.format(AVGSoldata);
    		System.out.println("Batez besteko soldata: " + "\t" +  AVGFormateatua+"€");
    		System.out.println("Enplegatu kopurua departamentuan: "+kontadorea);
    	}
	}
	}