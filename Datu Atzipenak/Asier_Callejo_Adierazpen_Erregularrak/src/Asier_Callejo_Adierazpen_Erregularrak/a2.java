package Asier_Callejo_Adierazpen_Erregularrak;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class a2 {
	static Scanner n=new Scanner(System.in);
	public static void ariketa(){
		System.out.println("Sartu katea");
		String katea = n.nextLine();
		//Katea abc izan behar du
		Pattern pat = Pattern.compile(".*abc.*");
		Matcher mat = pat.matcher(katea);
		if (mat.matches()) {
		System.out.println("BAI");
		} else {
		System.out.println("EZ");
		}
	}
}