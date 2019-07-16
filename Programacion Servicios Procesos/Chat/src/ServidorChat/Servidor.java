package ServidorChat;

import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

public class Servidor extends Thread {

	private VentanaServidor ventana;
	private final int PUERTO = 5000;
	private final int MAXIMO_CONEXIONES=3;

	public static ArrayList<ObjectOutputStream> lista = new ArrayList<ObjectOutputStream>();

	public Servidor(VentanaServidor ventana) {
		this.ventana=ventana;
	}

	public void run() {
		try {

			ServerSocket ss =new ServerSocket(PUERTO);
		System.out.println("Escucho el puerto "+PUERTO);
		for(int numCli=0;lista.size()<MAXIMO_CONEXIONES;numCli++) {
			Socket so = ss.accept();
			System.out.println((numCli+1)+"numero de clientes");
			ventana.txtConexiones.setText("Conexiones actuales = "+(numCli+1));
			ObjectInputStream entrada = new ObjectInputStream(so.getInputStream());
			ObjectOutputStream salida = new ObjectOutputStream(so.getOutputStream());
			lista.add(salida);
			System.out.println( so.getInetAddress().getHostAddress() + " conectado");
			RecibirMensaje recibir = new RecibirMensaje(entrada, salida, ventana);
			recibir.start();
		}
		ss.close();
		System.out.println("Demasiados clientes");

		}catch(Exception e){	
			e.printStackTrace();
		
		}
	}
	public void desconectar() {
		this.interrupt();
	}
}