package pack;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class Maneiatzailea extends DefaultHandler{
    private boolean aurkitutaCD=false;
    private int kont=0;
	private boolean aurkitutaT=false;
    private boolean aurkitutaA= false;
    private boolean aurkitutaCoun=false;
    private boolean aurkitutaCom= false;
    private boolean aurkitutaP= false;
    private boolean aurkitutaY=false;
	public Maneiatzailea(){
        super();}

       @Override
   public void startDocument() throws SAXException {
     // System.out.println("\nDokumentuaren hasiera...");
   }

   @Override
   public void endDocument() throws SAXException {
      //System.out.println("\nDokumentuaren bukaera...");
   }

   @Override
   public void startElement(String uri, String localName, String name,
         Attributes attributes) throws SAXException {
      /*System.out.println("\nEtiketa prozesatzen...");
      
      System.out.println("\tURI izen espazioa: "+uri);
      System.out.println("\tIzena: "+localName);
      System.out.println("\tAurrizkia: "+name);
      
      //Atributuak zeharkatuko ditugu
      System.out.println("\tProzesatzen "+attributes.getLength()+" atributuak...");
      for(int i=0;i<attributes.getLength();i++){
         System.out.println("\t\tIzena: "+attributes.getQName(i)+ "\t\tBalioa:Maneiatzailea.java "+attributes.getValue(i));

         
      }

      // Atributuak izenaren arabera ere atzitu ditzazkegu
      String valorId = attributes.getValue("id");
      if(valorId!=null){
         System.out.println("\tId: "+valorId);
      }*/
	   if(localName=="CD") {
		   aurkitutaCD=true;
		   kont++;
		   System.out.println("CD= " +kont);
		   
	   }
	   if(localName=="TITLE") {
		   aurkitutaT=true;
		   
	   }
	   if(localName=="ARTIST") {
		   aurkitutaA=true;
		   
	   }
	   if(localName=="COUNTRY") {
		   aurkitutaCoun=true;
		   
	   }
	   if(localName=="COMPANY") {
		   aurkitutaCom=true;
		   
	   }
	   if(localName=="PRICE") {
		   aurkitutaP=true;
		   
	   }
	   if(localName=="YEAR") {
		   aurkitutaY=true;
		   
	 
      
	   }
      
      
      

   }
   
   @Override
   public void characters(char[] ch, int start, int length)
         throws SAXException {
      /*System.out.println("\nEtiketa barruko testua prozesatzen... ");
      System.out.println("\nTestuaren luzera= "+length);
      System.out.println("\tTestua: "+String.valueOf(ch, start, length));*/
	   if(aurkitutaT==true) {
		   System.out.println("Titulua: "+ String.valueOf(ch, start, length));
		   aurkitutaT=false;
	   }
	   if(aurkitutaA==true) {
		   System.out.println("Artista: "+ String.valueOf(ch, start, length));
		   aurkitutaA=false;
	   }
	   if(aurkitutaCoun==true) {
		   System.out.println("Hiria: "+ String.valueOf(ch, start, length));
		   aurkitutaCoun=false;
	   }
	   if(aurkitutaCom==true) {
		   System.out.println("Disketxea: "+ String.valueOf(ch, start, length));
		   aurkitutaCom=false;
	   }
	   if(aurkitutaP==true) {
		   System.out.println("Pezioa: "+ String.valueOf(ch, start, length));
		   aurkitutaP=false;
	   }
	   if(aurkitutaY==true) {
		   System.out.println("Urtea: "+ String.valueOf(ch, start, length));
		   aurkitutaY=false;
	   }
   }

   @Override
   public void endElement(String uri, String localName, String name)
         throws SAXException {
      //System.out.println("\nEtiketaren bukaera...");
      //System.out.println("\tURI izen espazioa: "+uri);
     // System.out.println("\tIzena: "+localName);
      //System.out.println("\tAurrizkia: "+name);
   }

}
