package Asier_Callejo_ariketa5;

import java.util.StringTokenizer;

public class Asier_Callejo_ariketa5 {	
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		
		StringTokenizer();
		Split();
		indexOf();
		 // Substring
		 
	}
	public static void StringTokenizer() {
		//Tokenizatuko duguna deklaratzen dugu
		String frase= "this is an example";
		//Tokenizer deitzen dugu
		StringTokenizer st = new StringTokenizer(frase);
	     while (st.hasMoreTokens()) {
	    	 //Hemen esaldia banatu egingo du
	         System.out.println(st.nextToken());
	     }
	     }
	public static void Split(){
		//Banatu behar dugun String-a sortzen dugu
		String numeros = "1, bi,  3,   4,    5,     6";
		//Array batean sartzen ditugu eta split-arekin esaten diogu nola identifikatu ahal duen nola separatu 
        String[] numerosComoArray = numeros.split(",");
        for (int i = 0; i < numerosComoArray.length; i++) {
        	//Hemen lista sortzen du
            System.out.println(numerosComoArray[i]);
        }
    }
	public static void indexOf(){
	/*
	 * El método indexOf de la clase String de Java, nos permite obtener el índice de comienzo de una subcadena dentro de otra.
	 * Nos dice donde empieza lo que le ponemos entre parentesis
	*/
    String cadena = "Codigo Fuente en Java";
    int index = cadena.indexOf("Java"); 
    System.out.println(index);
  

/*
*Cuando queremos conocer sucesivas apariciones de una subcadena, podemos llamar la función repetidamente, pero con un segundo parametro que incluíra el índice de la última posición encontrada más 1. Por ejemplo:
*/

    cadena = "Codigo Fuente en Java y aca aparece otra vez Java";
    index = cadena.indexOf("Java"); 
    System.out.println(index);
    index = cadena.indexOf("Java",index+1); 
    System.out.println(index); // imprime segunda aparicion de Java

	}
}
