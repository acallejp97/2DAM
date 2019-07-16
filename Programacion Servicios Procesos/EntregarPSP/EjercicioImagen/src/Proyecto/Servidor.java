package Proyecto;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

import javax.swing.ImageIcon;

public class Servidor {
	
	private final int PUERTO = 5000;
	private String imagen="pug.png";
	private ImageIcon foto;
	
//Iniciamos el servidor
	public static void main(String[] args) {
		Servidor s1 = new Servidor();
		s1.iniciar();
	}
	
	public void iniciar() {

		ServerSocket servidor = null;
		Socket cliente = null;
		ObjectOutputStream salida = null;

		try {
			
			//Definimos el mismo puerto que el usuario y lo esperamos.
			servidor = new ServerSocket(PUERTO);
			System.out.println("Esperando conexiones del cliente...");
			
			//Aceptamos al cliente en el servidor
			cliente = servidor.accept();
			System.out.println("Cliente conectado.");
			
			//Le damos la imagen que queremos que imprima
			foto = new ImageIcon(imagen);
			salida = new ObjectOutputStream(cliente.getOutputStream());
			salida.writeObject(foto);

		} catch (IOException e) {
			System.out.println("Error: " + e.getMessage());
			
		} catch (Exception e) {
			System.out.println("Error: " + e.getMessage());
			
		} finally {
			try {
				//Si uno de los siguentes esta desconectado, cerramos la conexion
				if (servidor != null) 
					servidor.close();
				
				if (cliente != null) 
					cliente.close();
				
				if (salida != null) 
					salida.close();
				
				
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
}