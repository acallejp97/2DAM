package ServidorChat;

import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.ArrayList;

import javax.swing.DefaultListModel;

public class RecibirMensaje extends Thread {

	private ObjectInputStream entrada;
	private ObjectOutputStream salida;

	private VentanaServidor ventana;
	public static  ArrayList<String> lnick = new ArrayList<String>();

	public RecibirMensaje(ObjectInputStream entrada,ObjectOutputStream salida, VentanaServidor ventana) {
		this.entrada= entrada;
		this.salida= salida;
		this.ventana=ventana;
	}

	public void run() {
		try {
			while(true) {				
				String mensaje = entrada.readObject().toString();
				if(mensaje.startsWith(">")) {
					if(mensaje.contains("chat")) {
						String nick= mensaje.substring(1, mensaje.indexOf(" "));
						Servidor.lista.remove(lnick.indexOf(nick));
						lnick.remove(nick);
						DefaultListModel<String> listmodel=(DefaultListModel<String>) VentanaServidor.list.getModel();

						listmodel.removeElement(nick);
						ventana.txtConexiones.setText("Conexiones actuales = "+Servidor.lista.size());
						VentanaServidor.list.setModel(listmodel);
					}
					else {
						String nick= mensaje.substring(1, mensaje.indexOf(" "));
						lnick.add(nick);
						DefaultListModel<String> listmodel=(DefaultListModel<String>) VentanaServidor.list.getModel();

						listmodel.add(listmodel.size(), nick);
						VentanaServidor.list.setModel(listmodel);
					}
					

				}
				for(int i=0;i<Servidor.lista.size();i++) {
					Servidor.lista.get(i).writeObject(mensaje);
					
				}
				ventana.textArea.setText(ventana.textArea.getText()+"\n"+mensaje);	

				System.out.println("Imprimiendo "+mensaje);
				}
			
		}catch(Exception e){	
			e.printStackTrace();
		}
	}
}