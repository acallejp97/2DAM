package Asier_Callejo_Agenda;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

static ArrayList<kontaktuak> kontaktu=new ArrayList<kontaktuak>();
static Scanner s=new Scanner(System.in);
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		String izena, abizenak, NAN, Telefonoa,erantzuna="B";
		while (erantzuna.equals("B")){
			
			izena=Izenak.izenak();
			abizenak=Abizenak.abizenak();
			NAN=NANak.NAN();
			Telefonoa=Telefonoak.Telefonoak();
			
			kontaktuak  x = new kontaktuak (izena, abizenak, NAN, Telefonoa);
			kontaktu.add(x);
			System.out.println("Beste bat sartu?: B/E");
			erantzuna=s.nextLine().toUpperCase();
			
			while(!erantzuna.equals("B") && !erantzuna.equals("E")){
				System.out.println("Sartu bakarrik B edo E");
				erantzuna=s.nextLine().toUpperCase();
				
			}
				
			
		}
		System.out.println("***********************************************************************************************************************************");
		System.out.println("Zenbakia\t"+"Izena\t"+"Abizenak\t"+"NAN\t"+"Telefonoa\t\t");
		for (int i = 0; i < kontaktu.size(); i++) {
			System.out.println((i+1)+"		"+kontaktu.get(i).getIzena()+
			"	"+kontaktu.get(i).getAbizenal()+
			"		"+kontaktu.get(i).getNan()+
			"	"+kontaktu.get(i).getTelefono());
		}
		System.out.println("***********************************************************************************************************************************");
	}

}
