package Asier_Callejo_Salbuespenak;
import java.util.InputMismatchException;
import java.util.Scanner;
public class try_catch {
	static int errorea;
	static Scanner s=new Scanner (System.in);
	public static void adibidea(){
		try{
		
		System.out.println("Sartu izen bat");
		errorea=s.nextInt();
		}catch (InputMismatchException e){
			System.out.println("BARKATU!!!! ZENBAKIA ESAN NAHI NUEN");
			errorea=s.nextInt();
		}
	}
}
