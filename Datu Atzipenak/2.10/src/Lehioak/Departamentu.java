package Lehioak;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Kontroladorea.kontroladoreDepartamentu;
import konektatu.konexioa;

import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.naming.CommunicationException;
import javax.swing.JButton;
import java.awt.Font;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Departamentu extends JFrame {

	private JPanel contentPane;
	private JTextField TfKodea;
	private JTextField TfIzena;
	private JTextField TfKokapena;
	
	private JButton btnLehenengoa;
	private JButton btnHurrengoa;
	private JButton btnAzkenengoa;
	private JButton btnAurrrekoa;
	
	public konexioa kon=new konexioa();
	
	private static kontroladoreDepartamentu kontro;
	
	void konektatu_kontroladore(kontroladoreDepartamentu kontro) {
		
		btnLehenengoa.setActionCommand("lehenengo");
		btnLehenengoa.addActionListener(kontro);
		
		btnAzkenengoa.setActionCommand("azkenengo");
		btnAzkenengoa.addActionListener(kontro);
		
		btnHurrengoa.setActionCommand("hurrengo");
		btnHurrengoa.addActionListener(kontro);
		
		btnAurrrekoa.setActionCommand("aurreko");
		btnAurrrekoa.addActionListener(kontro);
	}

	/**
	 * Launch the application.
	 */
	
	/**
	 * Create the frame.
	 */
	public Departamentu() {
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel panel = new JPanel();
		contentPane.add(panel, BorderLayout.CENTER);
		panel.setLayout(null);
		
		JLabel lblKodea = new JLabel("Kodea:");
		lblKodea.setBounds(89, 14, 70, 15);
		panel.add(lblKodea);
		
		JLabel lblIzena = new JLabel("Izena:");
		lblIzena.setBounds(89, 41, 70, 15);
		
		panel.add(lblIzena);
		
		JLabel lblKokapen = new JLabel("Kokapena:");
		lblKokapen.setBounds(89, 68, 81, 15);
		panel.add(lblKokapen);
		
		TfKodea = new JTextField();
		TfKodea.setBounds(177, 12, 35, 19);
		TfKodea.setEditable(false);
		
		panel.add(TfKodea);
		TfKodea.setColumns(10);
		
		TfIzena = new JTextField();
		TfIzena.setBounds(177, 39, 114, 19);
		TfIzena.setEditable(false);
		panel.add(TfIzena);
		TfIzena.setColumns(10);
		
		TfKokapena = new JTextField();
		TfKokapena.setBounds(177, 66, 114, 19);
		TfKokapena.setEditable(false);
		panel.add(TfKokapena);
		TfKokapena.setColumns(10);
		
		btnLehenengoa = new JButton("Lehenengoa");
		btnLehenengoa.setFont(new Font("Dialog", Font.BOLD, 10));
		
		btnLehenengoa.setBounds(53, 128, 117, 25);
		panel.add(btnLehenengoa);
		
		btnHurrengoa = new JButton("Hurrengoa");
		btnHurrengoa.setBounds(53, 179, 117, 25);
		panel.add(btnHurrengoa);
		
		btnAzkenengoa = new JButton("Azkenengoa");
		btnAzkenengoa.setFont(new Font("Dialog", Font.BOLD, 10));
		btnAzkenengoa.setBounds(230, 130, 117, 25);
		panel.add(btnAzkenengoa);
		
		btnAurrrekoa = new JButton("Aurrekoa");
		btnAurrrekoa.setBounds(230, 179, 117, 25);
		panel.add(btnAurrrekoa);
		
		JButton btnMenu = new JButton("Menu Printzipala");
		btnMenu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Aukeratu frame = new Aukeratu();
				frame.setVisible(true);
			}
		});
		btnMenu.setFont(new Font("Dialog", Font.BOLD, 9));
		btnMenu.setBounds(263, 216, 117, 25);
		panel.add(btnMenu);
	}
	
		
	public JTextField getTfKodea() {
		return TfKodea;
	}
	
	public void setTfKodea(JTextField tfKodea) {
		TfKodea = tfKodea;
	}
	
	public JTextField getTfIzena() {
		return TfIzena;
	}
	
	public void setTfIzena(JTextField tfIzena) {
		TfIzena = tfIzena;
	}

	public JTextField getTfKokapena() {
		return TfKokapena;
	}

	public void setTfKokapena(JTextField tfKokapena) {
		TfKokapena = tfKokapena;
	}
	
}
