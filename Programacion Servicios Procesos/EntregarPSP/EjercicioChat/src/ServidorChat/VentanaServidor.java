package ServidorChat;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.ScrollPaneConstants;
import javax.swing.border.EmptyBorder;
import javax.swing.JList;
import javax.swing.JOptionPane;


public class VentanaServidor extends JFrame {

	private JPanel contentPane;
	public JTextField txtConexiones;
	public JTextArea textArea;
	public JButton btnSalir;
	private static Servidor servidor;
	public DefaultListModel<String> listmodel;
	public static JList<String> list;
	
	
	private final int PUERTO = 5000;

	public static void main(String[] args) {
		VentanaServidor s = new VentanaServidor();
		s.setVisible(true);
		servidor = new Servidor(s);
		servidor.start();
	}
	
	public VentanaServidor() {
		setTitle("Chat");
		setResizable(false);
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		setBounds(100, 100, 488, 318);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		listmodel=new DefaultListModel<>();
		 list = new JList(listmodel);
		list.setBounds(377, 11, 97, 224);
		contentPane.add(list);

		txtConexiones = new JTextField();
		txtConexiones.setEditable(false);
		txtConexiones.setBounds(12, 12, 344, 19);
		contentPane.add(txtConexiones);
		txtConexiones.setColumns(10);
		
		textArea = new JTextArea();
		textArea.setEditable(false);
	    JScrollPane scroll = new JScrollPane(textArea);
		scroll.setBounds(22, 43, 333, 192);
	    scroll.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
		contentPane.add(scroll);
		
		btnSalir = new JButton("Salir");
		btnSalir.setBounds(32, 253, 117, 25);
		contentPane.add(btnSalir);
		
		JButton btnEliminar = new JButton("Eliminar");
		btnEliminar.setBounds(377, 253, 97, 25);
		contentPane.add(btnEliminar);
		
		//ActionListener de los dos botones
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				//Salimos del chat expulsando a todos los usuarios del mismo
				for(int i=0;i<Servidor.lista.size();i++) {
					try {
						//Añadimos el * para que los usuarios identifiquen que ya no esta disponible el servidor
						Servidor.lista.get(i).writeObject("*");
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
				//Apagamos el servidor
				servidor.desconectar();
				dispose();
				System.exit(0);
			}
		});
		
		btnEliminar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				//Escogemos la posicion del usuario que se ha seleccionado
				int index = list.getSelectedIndex();
				//Lo eliminamos de la lista
				listmodel.remove(index);
				try {
					for(int i=0;i<Servidor.lista.size();i++) {
						if(i==index) {
							//Si el numero y el index del usuario coinciden se 
							//escribe esta "/" que significa que se le envia un mensaje al usuario de que ha sido expulsado
							Servidor.lista.get(index).writeObject("/");			    			
						}else {
							//Se le escribe en el chat del resto de usuarios un mensaje con el nombre del usuario que ha sido expulsado 
							Servidor.lista.get(i).writeObject(RecibirMensaje.lnick.get(index)+" ha sido expulsad@.");
						}
					}
					Servidor.lista.remove(index);
					//Escribimos la cantidad de usuarios de la lista en base al tamaño de la lista
					txtConexiones.setText("Conexiones actuales = "+Servidor.lista.size());
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
				//Miramos si habilitamos o no el boton de eliminar
				int size = listmodel.getSize();
				if (size == 0) btnEliminar.setEnabled(false);
				
				
			}
		});
	}
}

