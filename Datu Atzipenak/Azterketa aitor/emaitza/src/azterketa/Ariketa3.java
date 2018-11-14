package azterketa;


import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.StringTokenizer;

public class Ariketa3 {

	public static void main(String[] args) {
		IrakurriEguneratu("departamentuak.csv");
	}

	static void IrakurriEguneratu(String fitxategia) {
		try (BufferedReader fitx = new BufferedReader(new FileReader(fitxategia))) {
			String lerroa;
			while ((lerroa = fitx.readLine()) != null) {
				lerroa = lerroa.replace(" ", "");
				StringTokenizer st = new StringTokenizer(lerroa, ",");
				DEPARTAMENTUA dep = new DEPARTAMENTUA();
				switch (st.countTokens()) {
				case 1:
					dep.setKodea(new Integer(st.nextToken()));
					logaGehitu("Aldaketa gabeko lerroa:|" + dep.getKodea() + "|        |         |");
					break;
				case 2:
					dep.setKodea(new Integer(st.nextToken()));
					if (departamentuaBadago(dep.getKodea())) {
						String[] tokenak = lerroa.split(",,");
						if (tokenak.length > 1) {
						dep.setKokapena(tokenak[1]);
						//	departamentuaKokapenaAldatu(dep);
						String logtestua = dep.getKodea() + " duen departamentuaren kokapena=["+dep.getKokapena()+"] baliora aldatu da.";
						logaGehitu(logtestua);
						} else {
							dep.setIzena(st.nextToken());
						//	departamentuIzenaAldatu(dep);
							String logtestua = dep.getKodea() + " duen departamentuaren izena=["+dep.getIzena()+"] baliora aldatu da.";
							logaGehitu(logtestua);
						}
					} else {
						String logtestua = dep.getKodea() + " duen departamentua ez dago DBan beraz ezin da aldatu.";
						logaGehitu(logtestua);

					}
					break;
				case 3:
					dep.setKodea(new Integer(st.nextToken()));
					dep.setIzena(st.nextToken());
					dep.setKokapena(st.nextToken());
					//	departamentuaAldatu(dep);
					String logtestua = dep.getKodea() + " duen departamentua ondo aldatu da DBan.";
					logaGehitu(logtestua);
					break;
				default:
					break;
				}

			}

		} catch (FileNotFoundException fn) {
			System.out.println("Ez da departamentuak.csv fitxategia aurkitu.");
			logaGehitu("Ez da departamentuak.csv fitxategia aurkitu.");
		} catch (IOException io) {
			System.out.println(" S/Iko errorea gertatu egin da.");
			logaGehitu(" S/Iko errorea gertatu egin da.");
		} catch (Exception e) {
			System.out.println(" Salbuespena egon da." + e.fillInStackTrace().toString());
			logaGehitu(" Salbuespena egon da." + e.fillInStackTrace().toString());
		}

	}

	
	static boolean departamentuaBadago(int Zbkia) {
		Konexioa kon = new Konexioa();
		Connection konexioa = kon.getKonexioa();
		boolean badago = false;

		String sql = "{call hartuDepartamentua(?)}";
		CallableStatement deia;
		try {
			deia = konexioa.prepareCall(sql);
			deia.setInt(1, Zbkia);
			ResultSet emaitza = deia.executeQuery();
			if (emaitza.next())
				badago = true;
			emaitza.close();
			deia.close();
			konexioa.close();
		} catch (SQLException e) {
			logaGehitu(" Salbuespena egon da DATU basean dapartamentua bilatzean." + e.fillInStackTrace().toString());

		}
		return badago;
	}

	static void logaGehitu(String testua) {
		String logtestua;
		Date date = new Date();

		DateFormat hourdateFormat = new SimpleDateFormat("HH:mm:ss yyyy/MM/dd");
		logtestua = "[" + hourdateFormat.format(date) + "] " + testua;

		try (PrintWriter irteeraStream = new PrintWriter(new FileWriter("departamentuak.log", true));) {
			irteeraStream.println(logtestua);
		} catch (FileNotFoundException e) {
			System.err.println("Log Fitxategia ez da existitzen");
		} catch (Exception e) {
			System.err.println("Arazoa log fitxategia gordetzen");

		}
	}
}
