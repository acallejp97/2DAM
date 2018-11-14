package azterketa;


import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.StringTokenizer;

public class Ariketa2 {

	public static void main(String[] args) {
		IrakurriEguneratu("departamentuak.csv");
	}

	static void IrakurriEguneratu(String fitxategia) {
		try (BufferedReader fitx = new BufferedReader(new FileReader(fitxategia))) {
			String lerroa;
			while ((lerroa = fitx.readLine()) != null) {
				lerroa = lerroa.replace(" ", "");
				String formatoa="|%1$-4d|%2$-15S|%3$-15S|%n";
				StringTokenizer st = new StringTokenizer(lerroa, ",");
				DEPARTAMENTUA dep = new DEPARTAMENTUA();
				switch (st.countTokens()) {
				case 1:
					dep.setKodea(new Integer(st.nextToken()));
					System.out.printf(formatoa,dep.getKodea(),"","");
					break;
				case 2:
					dep.setKodea(new Integer(st.nextToken()));
					if(departamentuaBadago(dep.getKodea())){
						String[] tokenak = lerroa.split(",,");
						if (tokenak.length > 1) {
							dep.setKokapena(tokenak[1]);
							departamentuaKokapenaAldatu(dep);
							System.out.printf(formatoa,dep.getKodea(),"",dep.getKokapena());
						} else {
							dep.setIzena(st.nextToken());
							departamentuIzenaAldatu(dep);
							System.out.printf(formatoa,dep.getKodea(),dep.getIzena(),"");
						}
					}else{
						System.out.println(dep.getKodea()+" duen departamentua ez dago DBan beraz ezin da aldatu.");
					}
					break;
				case 3:
					dep.setKodea(new Integer(st.nextToken()));
					dep.setIzena(st.nextToken());
					dep.setKokapena(st.nextToken());
					departamentuaAldatu(dep);
					break;
				default:
					break;
				}

			}

		} catch (FileNotFoundException fn) {
			System.out.println("Ez da fitxategia aurkitu.");
		} catch (IOException io) {
			System.out.println(" S/Iko errorea gertatu egin da.");
		} catch (Exception e) {
			System.out.println(" Salbuespena egon da." + e.fillInStackTrace().toString());
		}

	}

	static void departamentuIzenaAldatu(DEPARTAMENTUA dep) {
		Konexioa kon = new Konexioa();
		Connection konexioa = kon.getKonexioa();
		String sql = "{call departamentuIzenaAldatu(?,?)}";
		;
		CallableStatement deia;
		try {
			deia = konexioa.prepareCall(sql);
			deia.setInt(1, dep.getKodea());
			deia.setString(2, dep.getIzena());
			deia.executeUpdate();
			deia.close();
			konexioa.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	static void departamentuaKokapenaAldatu(DEPARTAMENTUA dep) {
		Konexioa kon = new Konexioa();
		Connection konexioa = kon.getKonexioa();
		String sql = "{call departamentuaKokapenaAldatu(?,?)}";
		;
		CallableStatement deia;
		try {
			deia = konexioa.prepareCall(sql);
			deia.setInt(1, dep.getKodea());
			deia.setString(2, dep.getKokapena());
			deia.executeUpdate();
			deia.close();
			konexioa.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	static void departamentuaAldatu(DEPARTAMENTUA dep) {
		Konexioa kon = new Konexioa();
		Connection konexioa = kon.getKonexioa();
		String sql = "";
		if (departamentuaBadago(dep.getKodea()))
			sql = "{call departamentuaAldatu(?,?,?)}";
		else
			sql = "{call departamentuaSartu(?,?,?)}";
		CallableStatement deia;
		try {
			deia = konexioa.prepareCall(sql);
			deia.setInt(1, dep.getKodea());
			deia.setString(2, dep.getIzena());
			deia.setString(3, dep.getKokapena());
			deia.executeUpdate();
			deia.close();
			konexioa.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
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
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return badago;
	}

}
