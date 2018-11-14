package Lehioak;


public class isNumber {
	//Metodo hau Stringak zenbakiak diren edo ez balidatzeko da
    public static boolean isNumber(String cadena){
    	try {
    		Integer.parseInt(cadena);
    		return true;
    	} catch (NumberFormatException nfe){
    		return false;
    	}
    }
	}

