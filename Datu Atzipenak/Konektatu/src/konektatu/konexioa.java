package konektatu;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class konexioa {	
	public static Connection konekzioa = null;

	public konexioa() {

		String datubasea = "enpresa";
		String login = "root";
		String password = "admin";
		String host = "localhost";
		String url = "jdbc:mariadb://" + host + "/" + datubasea;
		//"jdbc:mariadb://localhost:3306/DB?user=root&password=myPassword");
		// Erregistratu driverra

		try {
			Class.forName("org.mariadb.jdbc.Driver");

		} catch (ClassNotFoundException e) {
			System.err.println("Errorea" + "org.mariadb.jdbc.Driver");
			System.err.println(e.toString());
		}

		konektatu1(url, login, password);
		//konektatu2(host, datubasea, login, password);

	}

	private static void konektatu1(String url, String login, String password) {
		
		// Konexioa sortu.
		try {
			konekzioa = (Connection) DriverManager.getConnection(url, login,password);
			
			System.out.println("Konexioa ondo burutu da !!!!");
		} catch (SQLException sqle) {
		
			System.err.println("Akats larria!!! Konexio1 ez da burutu");
			System.err.println(sqle.toString());
		}
	}
	public static Connection getKonekzioa() {
		return konekzioa;
	}
	public static void setKonekzioa(Connection konekzioa) {
		konexioa.konekzioa=konekzioa;
	}
	


}



