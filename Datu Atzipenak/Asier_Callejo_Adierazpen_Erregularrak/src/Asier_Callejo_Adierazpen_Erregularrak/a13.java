package Asier_Callejo_Adierazpen_Erregularrak;

public class a13 {
	public static void ariketa(){
		String str = "esto es un ejemplo de como funciona split";
		System.out.println("Katea: "+str);
		//Split-en adibide 1
		String [] cadenas = str.split("(e[s|m])|(pl)");
		for(int i = 0; i<cadenas.length; i++){
		System.out.println(cadenas[i]);
		}
}}
