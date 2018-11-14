package azterketa;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Konexioa {
	private String makina = "localhost";
	private String erabiltzailea = "root";
	private String pasahitza = "admin";
	private int ataka = 3306;
	private String zerbitzaria = "";
	private static Connection konexioa = null;
	private String datuBasea = "enpresaAitor";
	private String tipoa="jdbc";
	private String sqlMota="mysql";

	public Konexioa() {
		this.zerbitzaria = tipoa+":"+sqlMota+"://" + this.makina + ":" + this.ataka + "/" + datuBasea;

		try {
			Class.forName("org.mariadb.jdbc.Driver");
		} catch (ClassNotFoundException e) {
			System.err.println("AKATSA DRIVERRA ERREGISTRATZEAN.");
			System.exit(0);
		}

		try {
			konexioa = DriverManager.getConnection(this.zerbitzaria, this.erabiltzailea, this.pasahitza);
		} catch (SQLException e) {
			System.err.println("AKATSA ZERBITZARIA KONEKTATZEAN");
			System.exit(0);
		}
	//	System.out.println(datuBasea + " konektatua.");
	}

	public static Connection getKonexioa() {

		return konexioa;
	}

	public static void itxiKonexioa() {
		try {
			konexioa.close();
			// System.out.println("Datubasea deskonenktatu da.");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
