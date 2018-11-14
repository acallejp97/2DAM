package Lehioak;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Kontroladorea.kontroladoreDepartamentu;
import Kontroladorea.kontroladoreLangile;

import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Aukeratu extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Aukeratu frame = new Aukeratu();
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
	public Aukeratu() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel panel = new JPanel();
		contentPane.add(panel, BorderLayout.CENTER);
		panel.setLayout(null);
		
		JButton btnDepartamentu = new JButton("Departamentuak");
		btnDepartamentu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg1) {
							try {
								Departamentu frame1 = new Departamentu();
								frame1.setVisible(true);
								kontroladoreDepartamentu kontro=new kontroladoreDepartamentu(frame1);
								frame1.konektatu_kontroladore(kontro);
							} catch (Exception ex) {
								ex.printStackTrace();
							}
						}
					});
		btnDepartamentu.setBounds(12, 112, 169, 25);
		panel.add(btnDepartamentu);
		
		JButton btnLangileak = new JButton("Langileak");
		btnLangileak.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				try {
					Langile frame = new Langile();
					frame.setVisible(true);
					kontroladoreLangile kontro=new kontroladoreLangile(frame);
					frame.konektatu_kontroladorea(kontro);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
		btnLangileak.setBounds(282, 112, 117, 25);
		panel.add(btnLangileak);
	}
}
