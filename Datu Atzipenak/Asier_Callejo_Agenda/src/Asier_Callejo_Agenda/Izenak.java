package Asier_Callejo_Agenda;

import java.util.Scanner;
//Klase hau izena balidatzeko da
public class Izenak {
	static Scanner s=new Scanner(System.in);
	public static String izenak(){
		String izena="";
		System.out.println("Sartu izena");
		izena=s.nextLine();
		//Balidazioa egiten dut do/while batekin
		while (izena.length()<2 || izena.length()>20 && isNumber.isNumber(izena)==true){
			System.out.println("Ez du balio, gutxienez 2 karaktere eta gehienez 20 eta zenbakirik gabe");
			izena=s.nextLine();
		}
		return izena;
		
	}
	
}

