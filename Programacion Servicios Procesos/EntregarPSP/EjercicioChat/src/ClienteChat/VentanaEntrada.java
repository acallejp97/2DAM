package ClienteChat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import ServidorChat.Servidor;

import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.net.Socket;
import java.awt.event.ActionEvent;
import java.awt.Color;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class VentanaEntrada extends JFrame {

	private JPanel contentPane;
	private final JTextField textField = new JTextField();
	private final String HOST = "127.0.0.1";
	private final int PUERTO = 5000;
	private JButton btnNewButton;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaEntrada frame = new VentanaEntrada();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Crear frame.
	 */
	public VentanaEntrada() {
		setResizable(false);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 355, 180);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		JLabel lblNewLabel = new JLabel("Introduzca el nick:");
		lblNewLabel.setBounds(10, 41, 146, 15);
		contentPane.add(lblNewLabel);
		textField.setBounds(112, 38, 227, 19);
		contentPane.add(textField);
		textField.setColumns(10);

		JLabel label = new JLabel("");
		label.setForeground(Color.RED);
		label.setBounds(29, 107, 227, 15);
		contentPane.add(label);

		btnNewButton = new JButton("Aceptar");
		btnNewButton.setBounds(222, 115, 117, 25);
		contentPane.add(btnNewButton);

		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				//Validacion por si meten el nick vacio
				if (textField.getText().length() == 0) {
					label.setText("Debe introducir un nick");
				} else {
					try {
						//Miramos a ver si existe el nick que se le mete
						boolean utilizado = false;
						for (int i = 0; i < ServidorChat.RecibirMensaje.lnick.size(); i++) { 
							// los nicks usados a ver si ensa en la lista de usuarios
							if (ServidorChat.RecibirMensaje.lnick.get(i).equals(textField.getText())) {
								label.setText("El nick ya está en uso");
								utilizado = true;
							}
						}
						if (!utilizado) {
							//Conectamos al servidor
							Socket so = new Socket(HOST, PUERTO);
							System.out.println("Conexion realizada a " + HOST);
							System.out.println(textField.getText());
							//Iniciamos la ventana del chat
							VentanaCliente a = new VentanaCliente(so, textField.getText());
							a.setVisible(true);
							dispose();
						}
						
					} catch (Exception e) {
						label.setText("Error al conectarse");
						e.printStackTrace();
						System.out.println("Error: " + e.getMessage());
					}
					
				}
			}
		});
		//KeyListener del boton enter
		textField.addKeyListener(new KeyAdapter() {
			@Override
			public void keyPressed(KeyEvent e) {
				if (e.getKeyCode() == KeyEvent.VK_ENTER) {
					btnNewButton.doClick();
				}
			}
		});
	}
}
