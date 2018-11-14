package ariketa2;

import java.util.Scanner;

public class asier_callejo_ariketa2 {
static Scanner n=new Scanner(System.in);
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String frase;
		frase=n.nextLine();
		int e=-1;
		for (int i = 0; i <= frase.length(); i++) {
			e++;
		}
		System.out.println(e);
	}

}
