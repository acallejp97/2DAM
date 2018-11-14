package Asier_Callejo_Adierazpen_Erregularrak;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class a5 {
	static Scanner n=new Scanner(System.in);
	public static void ariketa(){
		System.out.println("Sartu katea");
		String katea = n.nextLine();
		//Letra larriz 5 kate edo gutxienez 10
		Pattern pat = Pattern.compile("[a­zA­Z]{5,10}");
		Matcher mat = pat.matcher(katea);
		if (mat.matches()) {
		System.out.println("BAI");
		} else {
		System.out.println("EZ");
		}
	}}

