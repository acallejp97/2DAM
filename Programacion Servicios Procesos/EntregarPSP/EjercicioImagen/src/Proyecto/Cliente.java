package Proyecto;
import java.awt.EventQueue;
import java.awt.Graphics2D;
import java.awt.geom.AffineTransform;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.net.Socket;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;

public class Cliente extends JFrame {

	private final int puerto = 5000;
	private final String ip = "127.0.0.1";
	private Socket cliente = null;
	private ObjectInputStream entrada = null;
	private ImageIcon imagen;
	private BufferedImage picture;
	private AffineTransform at;
	private String noDisp= "Nodisponible.png";
	private String fotoSer= "Fotoservidor.png";
	private ImageIcon foto;
	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Cliente cli = new Cliente();
					cli.setVisible(true);
					
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Cliente() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		JLabel labelImagen = new JLabel("");
		labelImagen.setBounds(57, 37, 291, 187);
		contentPane.add(labelImagen);

		try {
			//Creamos un nuevo socket e indicamos que ip utiliza y por que puerto sale (El mismo que el del servidor).
			cliente = new Socket(ip, puerto);
			System.out.println("Conexión realizada con servidor");
			
			//Metemos al cliente en el servidor
			entrada = new ObjectInputStream(cliente.getInputStream());
			
			//Aqui cogemos la imagen que se va a mostrar por pantalla que manda el servidor a traves del socket
			imagen = (ImageIcon) entrada.readObject();
			
			//Asignamos la imagen al labelImagen que tenemos creado en el layout y le las cosas para mostrarlo
			labelImagen.setIcon(imagen); 
			picture = new BufferedImage(imagen.getIconWidth(), imagen.getIconHeight(), BufferedImage.TYPE_INT_RGB);
			Graphics2D f2 = picture.createGraphics();
			at = AffineTransform.getTranslateInstance(0, 0);
			f2.drawImage(imagen.getImage(), at, imagen.getImageObserver());
			
			//Guardamos la foto en formato png, en la ruta que le decimos al archivo
			ImageIO.write(picture, "png", new File(fotoSer));

		} catch (Exception e) {
			//Si no hay image que mostrar, mostrara por defecto la imagen de no disponible.
			System.out.println("Error: " + e.getMessage());
			foto = new ImageIcon(noDisp);
			labelImagen.setIcon(foto);

		} finally {
			try {
				//Si alguno de los siguientes se cierra, cerramos la conexion
				if (cliente != null) 
					cliente.close();
				
				if (entrada != null) 
					entrada.close();
				
				
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
}