package Asier_Callejo_Adierazpen_Erregularrak;

import java.util.Scanner;



public class Asier_Callejo_Adierazpen_Erregularrak {
static Scanner n=new Scanner(System.in);
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Errorea ez edukitzeko
		int opcion=33;
		do{
		System.out.println("Aukeratu aukera bat:\n" +
				"1.Zihurtatu String kateak “abc” txantiloiarekin bat egiten duen katea duen ala ez.\n" +
				"2.Zihurtau ea String kateak “abc” txantiloiarekin bat egiten duen katea duen ala ez.\n" +
				"3.Zihurtatu String katea “abc”­tik hasi egiten dela.\n" +
				"4.Zihurtatu String katea “abc” edo “Abc”­tik hasi egiten dela.\n" +
				"5.Zihurtatu String katearen luzera gutxienez 5 letra larri edo xehe dituela eta gehienez 10.\n" +
				"6.Zihurtatu String katea ez dala zenbaki batekin hasten.\n" +
				"7.Zihurtatu String katea ez dala zenbaki batekin bukatzen\n" +
				"8.Zihurtatu String katea a edo b karakterez baino ez dagoela osatuta.\n" +
				"9.Zihurtatu katea Stringa 1 karakterea duen baina ez dagoen jarraituta 2 zenbakiagatik\n" +
				"10.Email baliogarriaren adierazpen erregularra.\n" +
				"11.String.matches()\n" +
				"12.String.split(regex) (1)\n" +
				"13.String.split(regex) (2)\n"+
				"0. Exit\n");
		//Aukera hartu eta clasera eramaten zaio
		opcion=n.nextInt();
		switch(opcion){
		case 1:a1.ariketa();break;
		case 2:a2.ariketa();break;
		case 3:a3.ariketa();break;
		case 4:a4.ariketa();break;
		case 5:a5.ariketa();break;
		case 6:a6.ariketa();break;
		case 7:a7.ariketa();break;
		case 8:a8.ariketa();break;
		case 9:a9.ariketa();break;
		case 10:a10.ariketa();break;
		case 11:a11.ariketa();break;
		case 12:a12.ariketa();break;
		case 13:a13.ariketa();break;
		default:;break;
		}
		}while (opcion!=0);
	}

}
