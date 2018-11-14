package Asier_Callejo_Agenda;

import java.util.Scanner;
//Abizenak sartzeko eta balidatzeko klasea
public class Abizenak {
	static Scanner s=new Scanner(System.in);
	public static String abizenak(){
		String abizena="";
		System.out.println("Sartu abizena");
		abizena = s.nextLine();
		while (abizena.length() < 2 || abizena.length()>30 && isNumber.isNumber(abizena)==true){
			System.out.println("Sartu abizen bat 2 eta 30 karaktere bitartean eta zenbakirik gabe");
			abizena=s.nextLine();
		}
		return abizena;
	}

}
