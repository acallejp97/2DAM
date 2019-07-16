package ClienteChat;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.border.EmptyBorder;

import ServidorChat.Servidor;
import ServidorChat.VentanaServidor;

import javax.swing.JTextField;
import javax.swing.ScrollPaneConstants;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.Socket;
import java.awt.event.ActionEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class VentanaCliente extends JFrame {

	private JPanel contentPane;
	public JTextField textField;
	public JTextArea textArea;
	public String nick;
	public JButton btnEnviar;
	public JButton btnSalir;
	private Socket so;

	public VentanaCliente(Socket so, String nick) {
		this.nick = nick;
		this.so = so;
		setResizable(false);
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		setTitle(nick);
		setBounds(100, 100, 454, 318);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		textField = new JTextField();
		textField.setBounds(12, 12, 297, 19);
		contentPane.add(textField);
		textField.setColumns(10);

		textArea = new JTextArea();
		textArea.setEditable(false);
		JScrollPane scroll = new JScrollPane(textArea);
		scroll.setBounds(22, 43, 414, 192);
		scroll.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		contentPane.add(scroll);

		btnEnviar = new JButton("Enviar");
		btnEnviar.setBounds(32, 254, 117, 22);
		contentPane.add(btnEnviar);

		btnSalir = new JButton("Salir");
		btnSalir.setBounds(319, 253, 117, 25);
		contentPane.add(btnSalir);
		Cliente cliente = new Cliente(so, this);
		cliente.mandarMensaje(">" + this.nick + " se ha conectado.");

		textField.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (textField.getText().length() != 0) {
					String mensaje = nick + ">" + textField.getText();
					cliente.mandarMensaje(mensaje);
					textField.setText("");
				}
			}
		});

		btnEnviar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (textField.getText().length() != 0) {
					
					//Añadimos el nick del usuario y el > para que el servidor identifique que es de un usuario y se manda al resto de usuarios
					String mensaje = nick + ">" + textField.getText();
					cliente.mandarMensaje(mensaje);
					textField.setText("");
				}
			}
		});
		
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
	
				//Añadimos el mensaje con la palabra "chat" para que el programa identifique que has abandonado el chat y cierras el programa
				cliente.mandarMensaje(">" + nick + " ha abandonado el chat.");			

				//Cerramos la ventana
				cliente.parar();
				dispose();
				System.exit(0);
			}
		});

		//btnEnter haga la funcion de aceptar
		textField.addKeyListener(new KeyAdapter() {
			@Override
			public void keyPressed(KeyEvent ke) {
				if (ke.getKeyCode() == KeyEvent.VK_ENTER) {
					btnEnviar.doClick();
				}
				
			}
		});
	}
}
