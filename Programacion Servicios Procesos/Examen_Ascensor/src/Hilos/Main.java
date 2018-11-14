package Hilos;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Color;

public class Main extends JFrame {

	private JPanel contentPane;
	private JTextField tfHora;
	private JTextField tfPisoRojo;
	private JTextField tfPisoAzul;
	
	private JButton btnSubirRojo;
	private JButton btnSubirAzul;
	
	private HiloHora reloj;

	private HiloBotones hiloAzul;
	private HiloBotones hiloRojo;
	
	private String nombre;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main frame = new Main();
					frame.setVisible(true);
					
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Main() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel panel = new JPanel();
		contentPane.add(panel, BorderLayout.CENTER);
		panel.setLayout(null);
		
		JLabel lblAscensor = new JLabel("ASCENSOR");
		lblAscensor.setBounds(87, 51, 56, 14);
		panel.add(lblAscensor);
		
		btnSubirRojo = new JButton("SUBIR");
		btnSubirRojo.setForeground(Color.WHITE);
		btnSubirRojo.setBackground(Color.RED);
		btnSubirRojo.setBounds(58, 110, 89, 23);
		panel.add(btnSubirRojo);
		
		btnSubirAzul = new JButton("SUBIR");
		btnSubirAzul.setForeground(Color.WHITE);
		btnSubirAzul.setBackground(Color.BLUE);
		btnSubirAzul.setBounds(59, 163, 89, 23);
		panel.add(btnSubirAzul);
		
		tfHora = new JTextField();
		tfHora.setForeground(Color.BLACK);
		tfHora.setBackground(Color.WHITE);
		tfHora.setBounds(260, 25, 112, 20);
		panel.add(tfHora);
		tfHora.setEditable(false);
		tfHora.setColumns(10);
		
		tfPisoRojo = new JTextField();
		tfPisoRojo.setForeground(Color.BLACK);
		tfPisoRojo.setBackground(Color.WHITE);
		tfPisoRojo.setText("");
		tfPisoRojo.setBounds(199, 111, 32, 20);
		panel.add(tfPisoRojo);
		tfPisoRojo.setEditable(false);
		tfPisoRojo.setColumns(10);
		tfPisoRojo.setText("0");
		
		tfPisoAzul = new JTextField();
		tfPisoAzul.setForeground(Color.BLACK);
		tfPisoAzul.setBackground(Color.WHITE);
		tfPisoAzul.setBounds(197, 164, 34, 20);
		panel.add(tfPisoAzul);
		tfPisoAzul.setEditable(false);
		tfPisoAzul.setColumns(10);
		tfPisoAzul.setText("0");
		
		
		reloj=new HiloHora(tfHora);
		reloj.start();
		
		
		hiloAzul=new HiloBotones(tfPisoAzul, "");
		hiloRojo=new HiloBotones(tfPisoRojo, "");
		//ActionListeners
		btnSubirAzul.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (btnSubirAzul.getText().equals("SUBIR")) {
					if (hiloAzul.getPiso()!=0) {
					hiloAzul.setPause(false);
					}else {
					hiloAzul.start();
					}
					btnSubirAzul.setText("PARAR");
					hiloRojo.setPause(true);
					btnSubirRojo.setText("SUBIR");
					//JOptionPane.showMessageDialog(null, "El ascensor AZUL está funcionando");
										
				}else {
					btnSubirAzul.setText("SUBIR");
					hiloAzul.setPause(true);
				}
				
			}
		});
		
		
		
		btnSubirRojo.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (btnSubirRojo.getText().equals("SUBIR")) {
					if (hiloRojo.getPiso()!=0) {
					hiloRojo.setPause(false);
					}else {
					hiloRojo.start();
					}
					btnSubirRojo.setText("PARAR");
					hiloAzul.setPause(true);
					btnSubirAzul.setText("SUBIR");
					//JOptionPane.showMessageDialog(null, "El ascensor ROJO está funcionando");
				}else {
					
					btnSubirRojo.setText("SUBIR");
					hiloRojo.setPause(true);
				}
				
			}
		});
		
	}
}
