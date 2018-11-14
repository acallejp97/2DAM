package Lehioak;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.JDialog;
import javax.swing.SwingConstants;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
public class Gehitu extends JFrame{
private JPanel contentPane;
private JTextField textUrte;
private JTextField textNori;
private JTextField textNork;
private JTextField textTitulua;
private JTextField textEdukia;

/**
 * Launch the application.
 */
public static void main(ActionEvent arg0) {
	EventQueue.invokeLater(new Runnable() {
		public void run() {
			try {
				Gehitu frame = new Gehitu();
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
public Gehitu() {
	setTitle("OHARREN INPRIMAKIA");
	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	setBounds(100, 100, 567, 347);
	contentPane = new JPanel();
	contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
	contentPane.setLayout(new BorderLayout(0, 0));
	setContentPane(contentPane);
	
	JPanel panel = new JPanel();
	panel.setToolTipText("");
	contentPane.add(panel, BorderLayout.CENTER);
	panel.setLayout(null);
	
	JLabel lblData = new JLabel("Data:");
	lblData.setBounds(30, 25, 70, 15);
	panel.add(lblData);
	
	textUrte = new JTextField();
	textUrte.setBounds(94, 23, 51, 19);
	panel.add(textUrte);
	textUrte.setColumns(10);
	String urte;
	urte=textUrte.getText();
	while(isNumber.isNumber(urte)==false) {
		textUrte.setText("");
	}
	
	JComboBox<String> comboHila = new JComboBox<String>();
	comboHila.setModel(new DefaultComboBoxModel<String>(new String[] {"Urtarrila", "Otsaila", "Martxoa", "Apirila", "Maiatza", "Ekaina", "Uztaila", "Abuztua", "Iraila", "Urria", "Azaroa", "Abendua"}));
	comboHila.setBounds(183, 20, 93, 24);
	panel.add(comboHila);
	String hila;
	hila=(String) comboHila.getSelectedItem();
	
	JComboBox<String> comboEguna = new JComboBox<String>();
	comboEguna.setModel(new DefaultComboBoxModel<String>(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"}));
	comboEguna.setBounds(314, 20, 70, 24);
	panel.add(comboEguna);
	String eguna;
	eguna=(String) comboEguna.getSelectedItem();
	
	JLabel label = new JLabel(":");
	label.setHorizontalAlignment(SwingConstants.CENTER);
	label.setBounds(128, 20, 70, 15);
	panel.add(label);
	
	JLabel label_1 = new JLabel(":");
	label_1.setHorizontalAlignment(SwingConstants.CENTER);
	label_1.setBounds(262, 25, 70, 15);
	panel.add(label_1);
	
	JLabel lblOrdua = new JLabel("Ordua:");
	lblOrdua.setBounds(30, 52, 70, 15);
	panel.add(lblOrdua);
	
	JComboBox<String> comboOrdu = new JComboBox<String>();
	comboOrdu.setModel(new DefaultComboBoxModel<String>(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}));
	comboOrdu.setBounds(104, 54, 51, 24);
	panel.add(comboOrdu);
	String ordu;
	ordu=(String) comboOrdu.getSelectedItem();
	
	JComboBox<String> comboMinutuak = new JComboBox<String>();
	comboMinutuak.setModel(new DefaultComboBoxModel<String>(new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"}));
	comboMinutuak.setBounds(193, 56, 62, 24);
	panel.add(comboMinutuak);
	String minutu;
	minutu=(String) comboMinutuak.getSelectedItem();
	
	JLabel label_2 = new JLabel(":");
	label_2.setHorizontalAlignment(SwingConstants.CENTER);
	label_2.setBounds(138, 54, 70, 15);
	panel.add(label_2);
	
	JLabel lblNori = new JLabel("Nori:");
	lblNori.setBounds(30, 105, 70, 15);
	panel.add(lblNori);
	
	textNori = new JTextField();
	textNori.setBounds(104, 103, 192, 19);
	panel.add(textNori);
	textNori.setColumns(10);
	String nori=textNori.getText();
			
	JLabel lblNewLabel = new JLabel("Nork:");
	lblNewLabel.setBounds(30, 129, 70, 15);
	panel.add(lblNewLabel);
	
	textNork = new JTextField();
	textNork.setBounds(104, 127, 192, 19);
	panel.add(textNork);
	textNork.setColumns(10);
	String nork=textNork.getText();
	
	JLabel lblTitulua = new JLabel("Titulua:");
	lblTitulua.setBounds(30, 154, 70, 15);
	panel.add(lblTitulua);
	
	textTitulua = new JTextField();
	textTitulua.setBounds(104, 152, 192, 19);
	panel.add(textTitulua);
	textTitulua.setColumns(10);
	String titulo=textTitulua.getText();
	
	JLabel lblEdukia = new JLabel("Edukia:");
	lblEdukia.setBounds(30, 181, 70, 15);
	panel.add(lblEdukia);
	
	textEdukia = new JTextField();
	textEdukia.setBounds(104, 179, 198, 65);
	panel.add(textEdukia);
	textEdukia.setColumns(10);
	String eduki=textEdukia.getText();
	
	JButton btnGorde = new JButton("Gorde");
	
	btnGorde.setBounds(328, 263, 93, 35);
	panel.add(btnGorde);
	gorde(urte, hila, eguna, ordu, minutu, nori, nork, titulo, eduki);
	
	JButton btnUtzi = new JButton("Utzi");
	btnUtzi.setBounds(433, 263, 98, 35);
	panel.add(btnUtzi);
	
	
}

static void gorde(String urte, String hila, String eguna, String ordu, String minutu, String nori, String nork, String titulo, String eduki) {
	//ArrayList.
}
}
