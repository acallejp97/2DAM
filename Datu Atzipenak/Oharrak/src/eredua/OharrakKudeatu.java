package eredua;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.StringTokenizer;

import javax.swing.JOptionPane;

public class OharrakKudeatu {
	private static ArrayList<Oharra> Oharrak = new ArrayList<Oharra>();
		

	public String inprimatuOharrak() {
		String testua = "";
		for (Iterator<Oharra> iterator = Oharrak.iterator(); iterator.hasNext();) {
			Oharra oharra = (Oharra) iterator.next();

			testua += "data:" + oharra.getData() + "\n";
			testua += "ordua:" + oharra.getOrdua() + "\n";
			testua += "nori:" + oharra.getNori() + "\n";
			testua += "nork:" + oharra.getNork() + "\n";
			testua += "titulua:" + oharra.getTitulua() + "\n";
			testua += "edukia:" + oharra.getEdukia() + "\n" + "******************************************\n";

		}
		return testua;
	}

	public static void kargatuOharrakFitxategitik() {
		int oharkopurua = 0;
		try (BufferedReader fitx = new BufferedReader(new FileReader("Oharrak.txt"))) {
			String lerroa;

			Oharra oharberria = null;
			while ((lerroa = fitx.readLine()) != null) {

				StringTokenizer st = new StringTokenizer(lerroa, ":");
				switch (st.nextToken()) {
				case "data":
					oharberria = new Oharra();
					oharberria.setData(st.nextToken());
					break;
				case "ordua":
					String orduak = st.nextToken();
					String minutuak = st.nextToken();
					String ordua = orduak + ":" + minutuak;
					oharberria.setOrdua(ordua);
					break;
				case "nori":
					oharberria.setNori(st.nextToken());
					break;
				case "nork":
					oharberria.setNork(st.nextToken());
					break;
				case "titulua":
					oharberria.setTitulua(st.nextToken());
					break;
				case "edukia":
					oharberria.setEdukia(st.nextToken());
					break;
				default:
					Oharrak.add(oharberria);
					oharkopurua++;
					break;
				}
			}

		} catch (FileNotFoundException fn) {
			System.out.println("MEMORIAN KARGATU: Ez da fitxategia aurkitu.");
			JOptionPane.showOptionDialog(null,"MEMORIAN KARGATU: Ez da fitxategia aurkitu.", "ERROREA!!!", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE, null, null, null);
		} catch (IOException io) {
			System.out.println("MEMORIAN KARGATU: S/Iko errorea gertatu egin da.");
			JOptionPane.showOptionDialog(null, "MEMORIAN KARGATU: S/Iko errorea gertatu egin da.", "ERROREA!!!", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE, null, null, null);
		} catch (Exception e) {
			System.out.println("MEMORIAN KARGATU: Salbuespena egon da.");
			JOptionPane.showOptionDialog(null, "MEMORIAN KARGATU: Salbuespena egon da.", "ERROREA!!!", JOptionPane.DEFAULT_OPTION, JOptionPane.ERROR_MESSAGE, null, null, null);
		}
		System.out.println("MEMORIAN KARGATU:" + oharkopurua + " ohar kargatu dira memorian.");
		JOptionPane.showMessageDialog(null, "MEMORIAN KARGATU:" + oharkopurua + " ohar kargatu dira memorian.");
	}
	

	public static void gordeOharrakFitxategian() {
		try (BufferedWriter doku = new BufferedWriter(new FileWriter("Oharrak.txt"))) {
			for (Iterator<Oharra> iterator = Oharrak.iterator(); iterator.hasNext();) {
				Oharra oharra = (Oharra) iterator.next();
				doku.write("data: " + oharra.getData());
				doku.newLine();
				doku.write("ordua: " + oharra.getOrdua());
				doku.newLine();
				doku.write("nori: " + oharra.getNori());
				doku.newLine();
				doku.write("nork: " + oharra.getNork());
				doku.newLine();
				doku.write("titulua: " + oharra.getTitulua());
				doku.newLine();
				doku.write("edukia: " + oharra.getEdukia());
				doku.newLine();
				doku.write("******************");
				doku.newLine();
			
				
			}
		} catch (FileNotFoundException ex) {
			System.out.println(ex.getMessage());
		} catch (IOException ex) {
			System.out.println(ex.getMessage());
		}
		JOptionPane.showMessageDialog(null, "Oharrak ondo sartu egin dira 'Oharrak.txt' fitxategian.");
		System.out.println("Oharrak ondo sartu egin dira 'Oharrak.txt' fitxategian.");
	}

	public static void gehituOharra(Oharra berria) {
		Oharrak.add(berria);
	}

}
