package ServidorChat;

import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

public class Servidor extends Thread {

	private VentanaServidor ventana;
	private final int PUERTO = 5000;
	private final int MAXIMO_CONEXIONES = 3;
	private Socket so;
	private ObjectInputStream entrada;
	private ObjectOutputStream salida;
	public static ArrayList<ObjectOutputStream> lista = new ArrayList<ObjectOutputStream>();

	public Servidor(VentanaServidor ventana) {
		this.ventana = ventana;
	}

	public void run() {
		try {

			ServerSocket ss = new ServerSocket(PUERTO);
			//Aceptamos siempre que sean menos de tres clientes
			for (int numCli = 0; lista.size() < MAXIMO_CONEXIONES; numCli++) {
					so = ss.accept();
					//Escibimos en el TextBox el numero de conexiones
					ventana.txtConexiones.setText("Conexiones actuales = " + (numCli + 1));
					entrada = new ObjectInputStream(so.getInputStream());
					salida = new ObjectOutputStream(so.getOutputStream());
					//Añadimos el nombre de usuario a la lista
					lista.add(salida);
					//Metemos al usuario en la clase de recibir mensaje para que pueda recibir los mensajes 
					RecibirMensaje recibir = new RecibirMensaje(entrada, salida, ventana);
					recibir.start();

			}
			ss.close();
			System.out.println("Demasiados clientes");

		} catch (Exception e) {
			e.printStackTrace();

		}
	}

	public void desconectar() {
		this.interrupt();
	}
}