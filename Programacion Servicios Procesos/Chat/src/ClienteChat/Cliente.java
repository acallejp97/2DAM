package ClienteChat;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.OutputStream;
import java.net.Socket;

public class Cliente{

	private Socket socket;
	private VentanaCliente ventana;
	private ObjectOutputStream salida;
	private RecibirMensaje recibir;
	public Cliente(Socket so, VentanaCliente ventana) {
		this.socket = so;
		this.ventana=ventana;
		ObjectInputStream entrada = null;

		try {
			salida = new ObjectOutputStream(socket.getOutputStream());
			entrada = new ObjectInputStream(socket.getInputStream());
	} catch (IOException e) {
			e.printStackTrace();
		}
		 recibir =  new RecibirMensaje(entrada, ventana);
		recibir.start();
	}
	public void mandarMensaje(String mensaje) {
		try {
			salida.writeObject(mensaje);

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public void parar() {
		try {
			salida.close();
			socket.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		recibir.interrupt();
	}
}
