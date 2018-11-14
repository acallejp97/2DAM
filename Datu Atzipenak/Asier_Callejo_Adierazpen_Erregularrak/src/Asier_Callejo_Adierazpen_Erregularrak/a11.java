package Asier_Callejo_Adierazpen_Erregularrak;


import java.util.Scanner;

public class a11 {
	static Scanner n=new Scanner(System.in);
	public static void ariketa(){
		System.out.println("Sartu katea");
		String katea = n.nextLine();
		//Match frogatzeko metodoa 
		if (katea.matches(".*1(?!2).*")) {
			System.out.println("BAI");
			} else {
			System.out.println("EZ");
			}
	}}