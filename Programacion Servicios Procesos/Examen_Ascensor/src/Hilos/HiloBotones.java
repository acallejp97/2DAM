package Hilos;


import javax.swing.JTextField;

public class HiloBotones extends Thread{
	int piso= 0;
	boolean pause = false;
	JTextField label;
	String nombre;
	
	public HiloBotones(JTextField label, String nombre) {
		this.label = label;
		this.nombre = nombre;
	}
	
	
	public void estadoinicial(){
		piso=0;
		
		this.display();
	}
	
	//metodo para que empiezen los pisos
	public void run(){
		try{
			for(int i=0;i<=10;i++){
				if(!pause){
					//incrementamos un piso, y mostramos
					this.increment();
					this.display();
				}
				//esperamos un segundo y repetimos
				Thread.sleep(1200);
			}
		}catch(Exception e){
			
		}
	}
	
	
	public void display(){
		String strSeg = Integer.toString(piso);
			
		String tiempomostrar = strSeg;
		label.setText(tiempomostrar);
	}
	
	//incrementamos pisos
	public void increment(){
		piso++;
		if(piso==10){
			setPause(true);			
		}
	}
	
	public void setPause(boolean pause){
		this.pause=pause;
	}
	
	public boolean getPause(){
		return pause;
	}
	
	public void setPiso(int num){
		this.piso=num;
	}


	public int getPiso() {
		return piso;
	}
	
	
}
