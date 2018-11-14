package Hilos;

import java.text.SimpleDateFormat;
import java.util.Date;

import javax.swing.JTextField;

public class HiloHora extends Thread{
	String hora;
	private JTextField label;
	Date ho=new Date();
	SimpleDateFormat sdf =new SimpleDateFormat("HH:mm:ss");
	
	public HiloHora(JTextField tfHora) {
		super();
		this.label=tfHora;
	}
	public void run() {
		try {
		for(;;) {
			incrementar();
		}
		
		}catch(Exception ex) {
			
		}
	}
	public void incrementar() {
		Date ho=new Date();
		SimpleDateFormat sdf =new SimpleDateFormat("HH:mm:ss");
		hora=sdf.format(ho);
		label.setText(hora+" Asier");
	}
	}