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
	public static ArrayList<String> lnick = new ArrayList<String>();

	public RecibirMensaje(ObjectInputStream entrada, ObjectOutputStream salida, VentanaServidor ventana) {
		this.entrada = entrada;
		this.salida = salida;
		this.ventana = ventana;
	}

	public void run() {
		try {
			while (true) {
				String mensaje = entrada.readObject().toString();
				//Esto significa que lo manda el usuario
				if (mensaje.startsWith(">")) {
					
				//Esto es para cuando el usario abandona el chat, ya que es el unico mensaje que incluye esta palabra
					if (mensaje.contains("chat")) {
						
						//Se le quita de la lista de usuarios conectados y se tiene que actualizar el numero de usuarios conectados
						String nick = mensaje.substring(1, mensaje.indexOf(" "));
						Servidor.lista.remove(lnick.indexOf(nick));
						lnick.remove(nick);
						DefaultListModel<String> listmodel = (DefaultListModel<String>) VentanaServidor.list.getModel();
						listmodel.removeElement(nick);
						ventana.txtConexiones.setText("Conexiones actuales = " + Servidor.lista.size());
						VentanaServidor.list.setModel(listmodel);
						
						//En cambio si el mensaje lo manda el servidor
					} else {
						
						//Se le expulsa del servidor sin dejar ningun mensaje desde esta clase
						String nick = mensaje.substring(1, mensaje.indexOf(" "));
						lnick.add(nick);
						DefaultListModel<String> listmodel = (DefaultListModel<String>) VentanaServidor.list.getModel();
						listmodel.add(listmodel.size(), nick);
						VentanaServidor.list.setModel(listmodel);
					}

				}
				
				//Se escribe en la ventana de los usuarios el mensaje que se ha mandado 
				for (int i = 0; i < Servidor.lista.size(); i++) {
					Servidor.lista.get(i).writeObject(mensaje);

				}
				//Se escribe en el text area del servidor el mensaje
				ventana.textArea.setText(ventana.textArea.getText() + "\n" + mensaje);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}