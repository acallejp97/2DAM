package Asier_Callejo_Adierazpen_Erregularrak;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class a6 {
	static Scanner n=new Scanner(System.in);
	public static void ariketa(){
		System.out.println("Sartu katea");
		String katea = n.nextLine();
		//Katea ez da zenbakiz hasten
		Pattern pat = Pattern.compile("^[^\\d].*");
		Matcher mat = pat.matcher(katea);
		if (mat.matches()) {
		System.out.println("BAI");
		} else {
		System.out.println("EZ");
		}
	}}
