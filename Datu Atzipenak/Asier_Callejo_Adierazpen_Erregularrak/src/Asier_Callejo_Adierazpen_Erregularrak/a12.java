package Asier_Callejo_Adierazpen_Erregularrak;

public class a12 {
	public static void ariketa(){
		String str = "zuri­gorri:hori.berde_urdina";
		System.out.println("katea: "+str);
		//Split-en adibide 1
		String [] kateak = str.split("[­:._]");
		for(int i = 0; i<kateak.length; i++){
		System.out.println(kateak[i]);
		}
}}
