package azterketa;


public class DEPARTAMENTUA {
private int kodea;
private String izena;
private String kokapena;



public DEPARTAMENTUA() {
	super();
	// TODO Auto-generated constructor stub
}

public DEPARTAMENTUA(int kodea, String izena, String kokapena) {
	this.kodea = kodea;
	this.izena = izena;
	this.kokapena = kokapena;
}

public int getKodea() {
	return kodea;
}

public void setKodea(int kodea) {
	this.kodea = kodea;
}

public String getIzena() {
	return izena;
}

public void setIzena(String izena) {
	this.izena = izena;
}

public String getKokapena() {
	return kokapena;
}

public void setKokapena(String kokapena) {
	this.kokapena = kokapena;
}

@Override
public String toString() {
	return "|kodea=" + kodea + "| izena=" + izena + "|kokapena=" + kokapena + "|";
}





}
