package Lehioak;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Menuak extends JFrame {
	
	/**
	 * 
	 */

	private JPanel contentPane;
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Menuak frame = new Menuak();
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
	public Menuak() {
		setTitle("OHARREN KUDEAKETA");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(new BorderLayout(0, 0));
		
		JPanel panel = new JPanel();
		contentPane.add(panel, BorderLayout.CENTER);
		panel.setLayout(null);
		
		JButton btnKargatu = new JButton("Kargatu Oharrak");
		btnKargatu.setBounds(135, 36, 174, 25);
		panel.add(btnKargatu);
		
		JButton btnGorde = new JButton("Gorde Oharrak");
		btnGorde.setBounds(135, 110, 174, 25);
		panel.add(btnGorde);
	
		
		JButton btnGehitu = new JButton("Gehitu Oharrak");
		btnGehitu.setBounds(135, 73, 174, 25);
		panel.add(btnGehitu);
		
		
		JButton btnInprimatu = new JButton("Inprimatu");
		btnInprimatu.setBounds(135, 147, 174, 25);
		panel.add(btnInprimatu);
		
		JButton btnIrten = new JButton("Irten");
		btnIrten.setBounds(135, 184, 174, 25);
		panel.add(btnIrten);
	}
}
