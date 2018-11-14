package Asier_Callejo_Agenda;

public class kontaktuak {
	
	private String izena;
	private String abizenak;
	private String NAN;
	private String telefonoa;
	public kontaktuak(String izena, String abizenak, String NAN, String telefonoa) {
		this.izena = izena;
		this.abizenak = abizenak;
		this.NAN = NAN;
		this.telefonoa = telefonoa;
	}

	public String getIzena() {
		return izena;
	}

	public void setIzena(String izena) {
		this.izena = izena;
	}

	public String getAbizenal() {
		return abizenak;
	}

	public void setAbizenak(String abizenak) {
		this.abizenak = abizenak;
	}

	public String getNan() {
		return NAN;
	}

	public void setNan(String nan) {
		this.NAN = nan;
	}

	public String getTelefono() {
		return telefonoa;
	}

	public void setTelefono(String telefono) {
		this.telefonoa = telefono;
	}
	
}
