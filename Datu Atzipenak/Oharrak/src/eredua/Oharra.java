package eredua;




import java.io.Serializable;


public class Oharra implements Serializable {
    
   
	private static final long serialVersionUID = 1L;
	private String data;
    private String ordua;
    private String nori;
    private String nork;
    private String titulua;
    private String edukia;
    
    public Oharra(){
    	
    }
    
    public Oharra(String data,String ordua,String nori,String nork,String titulua,String edukia){
        this.data=data;
        this.ordua=ordua;
        this.nori=nori;
        this.nork=nork;
        this.titulua=titulua;
        this.edukia=edukia;
                
    }

    public String getData() {
        return data;
    }

    public void setData(String data) {
        this.data = data;
    }

    public String getOrdua() {
        return ordua;
    }

    public void setOrdua(String ordua) {
        this.ordua = ordua;
    }

    public String getNori() {
        return nori;
    }

    public void setNori(String nori) {
        this.nori = nori;
    }

    public String getNork() {
        return nork;
    }

    public void setNork(String nork) {
        this.nork = nork;
    }

    public String getTitulua() {
        return titulua;
    }

    public void setTitulua(String titulua) {
        this.titulua = titulua;
    }

    public String getEdukia() {
        return edukia;
    }

    public void setEdukia(String edukia) {
        this.edukia = edukia;
    }

    @Override
	public String toString() {
		return "Oharra [data=" + data + ", ordua=" + ordua + ", nori=" + nori + ", nork=" + nork + ", titulua="
				+ titulua + ", edukia=" + edukia + "]";
	}
    
    
    
}
