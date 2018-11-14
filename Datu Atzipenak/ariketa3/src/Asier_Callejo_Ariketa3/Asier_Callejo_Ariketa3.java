package Asier_Callejo_Ariketa3;

import java.util.Scanner;

public class Asier_Callejo_Ariketa3 {
static Scanner n=new Scanner(System.in);
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nombre;
		double numero;
		double karratu;
		System.out.println("Sartu zure izena");
		nombre=n.nextLine();
		System.out.println("Sartu zenbakia");
		numero=n.nextDouble();
		karratu=numero*numero;
		System.out.println(nombre+" "+numero+" "+karratu);
		
	}

}
