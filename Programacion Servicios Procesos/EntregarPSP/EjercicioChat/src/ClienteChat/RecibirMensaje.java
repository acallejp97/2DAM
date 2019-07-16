package ClienteChat;

import java.io.ObjectInputStream;

import javax.swing.JOptionPane;

import ServidorChat.Servidor;

public class RecibirMensaje extends Thread {

	private VentanaCliente ventana;
	private ObjectInputStream entrada;

	public RecibirMensaje(ObjectInputStream entrada, VentanaCliente ventana) {
		this.entrada = entrada;
		this.ventana = ventana;
	}

	public void run() {
		try {
			String mensaje;
			// Hacemos este while hasta que el servidor se caiga
			do {
				mensaje = entrada.readObject().toString();

				// Si el mensaje que llega contiene un * significa que el servidor se ha caido
				if (mensaje.equals("*")) {

					JOptionPane.showMessageDialog(null, "Se ha caido el servidor");
					ventana.textField.setEnabled(false);
					ventana.btnEnviar.setEnabled(false);

					// Si incluye esto se imprime un OptionPane advirtiendo que ha sido expulsado
				} else if (mensaje.equals("/")) {
					JOptionPane.showMessageDialog(null, "Has sido expulsad@");
					entrada.close();

					// Interrumpimos el while y cerramos la pestaña
					interrupt();
					System.exit(0);

					// Si todo va normal se imprime solamente el mensaje
				} else
					ventana.textArea.setText(ventana.textArea.getText() + "\n" + mensaje);

			} while (!mensaje.equals("*"));

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
