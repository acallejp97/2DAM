package Asier_Callejo_Adierazpen_Erregularrak;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class a10 {
	static Scanner sc = new Scanner(System.in);
	public static void ariketa(){
	String email;
	System.out.print("Sartu helbide elektronikoa: ");
	email = sc.nextLine();
	//Emailaren balidazioa da
	Pattern pat = Pattern.compile ("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$");
	Matcher mat = pat.matcher(email);
	if(mat.find()){
	System.out.println("Helbide baliogarria");
	}else{
	System.out.println("Helbide honek ez du balio.");
}
}}
