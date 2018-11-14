package Asier_Callejo_Adierazpen_Erregularrak;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class a3 {
	static Scanner n=new Scanner(System.in);
	public static void ariketa(){
		System.out.println("Sartu katea");
		String katea = n.nextLine();
		//Katea abc-s hasi egiten da
		Pattern pat = Pattern.compile("^abc.*");
		Matcher mat = pat.matcher(katea);
		if (mat.matches()) {
		System.out.println("Baliogarria");
		} else {
		System.out.println("Ez du balio");
		}
	}}