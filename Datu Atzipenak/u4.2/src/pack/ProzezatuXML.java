package pack;

import java.io.FileInputStream;
import java.io.IOException;

import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

public class ProzezatuXML {
	public static void main(String[] args) {
		try {
	         // Sortu parseatzaileen faktoria
	         XMLReader reader = XMLReaderFactory.createXMLReader();
	         // Readerrari gure maneiatzailea gehituko diogu
	         reader.setContentHandler(new Maneiatzailea());         
	         // XML adibideko fitxategia parseatuko dugu
	         reader.parse(new InputSource(new FileInputStream("fitxategia.xml")));
	      } catch (SAXException e) {
	         e.printStackTrace();
	      } catch (IOException e) {
	         e.printStackTrace();
	      }

	   }

}
