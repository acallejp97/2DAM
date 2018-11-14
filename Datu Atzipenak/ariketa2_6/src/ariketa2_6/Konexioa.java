package ariketa2_6;

import java.sql.*;

public class Konexioa {  
	   
		public static Connection konekzioa = null;

		public Konexioa() {

			
			String datubasea = "enpresa";
			String login = "root";
			String password = "admin";
			String host = "localhost";
			String url = "jdbc:mariadb://" + host + "/" + datubasea;
			//"jdbc:mariadb://localhost:3306/DB?user=root&password=myPassword"
			// Erregistratu driverra

			try {
				Class.forName("org.mariadb.jdbc.Driver");

			} catch (ClassNotFoundException e) {
				System.err.println("Errorea" + "org.mariadb.jdbc.Driver");
				System.err.println(e.toString());
			}

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

}
