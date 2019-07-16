package ClienteChat;

import java.io.ObjectInputStream;

import javax.swing.JOptionPane;

import ServidorChat.Servidor;

public class RecibirMensaje extends Thread {

	private VentanaCliente ventana;
	private ObjectInputStream entrada;

	
	public RecibirMensaje(ObjectInputStream entrada, VentanaCliente ventana) {
		this.entrada = entrada;
		this.ventana= ventana;
	}

	public void run() {
		try {
			String mensaje;
			do{
				mensaje = entrada.readObject().toString();
				if(mensaje.equals("*")) {
					JOptionPane.showMessageDialog(null, "Se ha caído el servidor");
					ventana.textField.setEnabled(false);
					ventana.btnEnviar.setEnabled(false);
				}
				else if(mensaje.equals("/")) {
					JOptionPane.showMessageDialog(null, "Has sido expulsad@");
					entrada.close();
					interrupt();
					System.exit(0);
				}
				else {
					ventana.textArea.setText(ventana.textArea.getText()+"\n"+mensaje);	
					System.out.println("recibido"+mensaje);					
				}
			}while(!mensaje.equals("*"));
		}catch(Exception e){
			e.printStackTrace();
		}
	}
}
