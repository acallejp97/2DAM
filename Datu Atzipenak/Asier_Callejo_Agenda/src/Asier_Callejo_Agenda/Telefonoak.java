package Asier_Callejo_Agenda;
import java.util.Scanner;
public class Telefonoak {
	static Scanner s=new Scanner(System.in);
	public static String Telefonoak(){
		String telefonoa="";
		System.out.println("Sartu telefono bat");
		telefonoa=s.nextLine();
		while(telefonoa.length()!=9 && isNumber.isNumber(telefonoa)==false){
			System.out.println("Sartu balio duen telefono zenbaki bat");
			telefonoa=s.nextLine();
		//Aldatu dut eta bakarrik 9 zenbaki
		}
		return telefonoa;
	}
}
