package Asier_Callejo_Agenda;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class NANak {
	static Scanner s=new Scanner(System.in);
public static String NAN(){
	String NAN="";
	System.out.println("Sartu NAN zenbakia");
	NAN=s.nextLine();
	
	while(NAN.length()!=9 && balidatu(NAN)==false){
		System.out.println("Sartu NAN balio zuzen bat");
		NAN=s.nextLine();
	}
	return NAN;
}
//Interneten bilatutako metodo bat
public static boolean balidatu(String NAN){
	 boolean zuzena = false;

	    Pattern pattern = Pattern.compile("(\\d{1,8})([TRWAGMYFPDXBNJZSQVHLCKEtrwagmyfpdxbnjzsqvhlcke])");
	    Matcher matcher = pattern.matcher(NAN);
	    if (matcher.matches()) {
	        String letra = matcher.group(2);
	        String letras = "TRWAGMYFPDXBNJZSQVHLCKE";
	        int index = Integer.parseInt(matcher.group(1));
	        index = index % 23;
	        String reference = letras.substring(index, index + 1);
	        if (reference.equalsIgnoreCase(letra)) {
	            zuzena = true;
	        } else {
	            zuzena = false;
	        }
	    } else {
	        zuzena = false;
	    }
	    return zuzena;
	}
}

