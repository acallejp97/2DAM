package Lehioak;

import java.awt.BorderLayout;
import java.awt.Button;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Kontroladorea.kontroladoreLangile;
import konektatu.konexioa;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JSeparator;
import javax.naming.CommunicationException;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import java.awt.Font;
import java.awt.Frame;

import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;

import java.awt.event.ActionEvent;
import java.awt.event.KeyAdapter;

public class Langile extends JFrame {
	
	private DateFormat df=new SimpleDateFormat("yyyy-M-d");
	private Date date;


	private JPanel contentPane;
	private JTextField tfZbkia;
	private JTextField tfAbizena;
	private JTextField tfLanbidea;
	private JTextField tfSoldata;
	private JTextField tfKomisioa;
	private JTextField tfData;
	
	private JButton btnKontsultaEgin;
	private JButton btnSartu;
	private JButton btnEzabatu;
	private JButton btnAldatu;
	private JButton btnGarbitu;
	private JButton btnIrten;
	private JButton btnExtra;
	
	private JComboBox boxDepart;
	private JComboBox boxZuzen; 

	private static kontroladoreLangile kontro;
	
	void konektatu_kontroladorea(kontroladoreLangile kontro) {
		
		btnKontsultaEgin.setActionCommand("Kontsulta");
		btnKontsultaEgin.addActionListener(kontro);
		
		btnSartu.setActionCommand("Sartu");
		btnSartu.addActionListener(kontro);
		
		btnEzabatu.setActionCommand("Ezabatu");
		btnEzabatu.addActionListener(kontro);
		
		btnAldatu.setActionCommand("Aldatu");
		btnAldatu.addActionListener(kontro);
		
		
		
	}
	
	konexioa kon=new konexioa();
	Connection conexion = kon.getKonekzioa();
	java.sql.Date fecha_alt=new java.sql.Date(System.currentTimeMillis());
	

	/**
	 * Launch the application.
	 */
	

	/**
	 * Create the frame.
	 * 
	 * 
	 */
	public Langile() throws SQLException{
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 520, 355);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel panel = new JPanel();
		contentPane.add(panel, BorderLayout.CENTER);
		panel.setLayout(null);
		
		JLabel lblZbkia = new JLabel("Zbkia");
		lblZbkia.setBounds(12, 60, 70, 15);
		panel.add(lblZbkia);
		
		JLabel lblAbizena = new JLabel("Abizena");
		lblAbizena.setBounds(12, 87, 70, 15);
		panel.add(lblAbizena);
		
		JLabel lblLanbidea = new JLabel("Lanbidea");
		lblLanbidea.setBounds(12, 108, 70, 15);
		panel.add(lblLanbidea);
		
		JLabel lblSoldata = new JLabel("Soldata");
		lblSoldata.setBounds(12, 135, 70, 15);
		panel.add(lblSoldata);
		
		JLabel lblKomisioa = new JLabel("Komisioa");
		lblKomisioa.setBounds(12, 162, 70, 15);
		panel.add(lblKomisioa);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(12, 189, 484, 2);
		panel.add(separator);
		
		btnKontsultaEgin = new JButton("KONTSULTA EGIN");
		btnKontsultaEgin.setBounds(261, 19, 216, 25);
		panel.add(btnKontsultaEgin);
		
		boxDepart = new JComboBox();
		boxDepart.setBounds(271, 55, 206, 24);
		panel.add(boxDepart);
		Statement SentenciaDEP=conexion.createStatement();
		ResultSet rs1 = SentenciaDEP.executeQuery("Select dnombre, dept_no FROM departamentos;");
		while (rs1.next()) {boxDepart.addItem(rs1.getString(2)+"/"+rs1.getString(1));}
		
		
		
		
		boxZuzen = new JComboBox();
		boxZuzen.setBounds(271, 87, 206, 24);
		panel.add(boxZuzen);
		Statement SentenciaZUZ=conexion.createStatement();
		ResultSet rs2 = SentenciaDEP.executeQuery("Select emp_no, apellido FROM empleados where OFICIO='DIRECTOR' OR OFICIO='PRESIDENTE';");
		while (rs2.next()) {boxZuzen.addItem(rs2.getString(1)+"/"+rs2.getString(2));}

				
		
		tfZbkia = new JTextField();
		tfZbkia.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent ke) {
				  char c=ke.getKeyChar(); 
			         if(Character.isLetter(c)) { 
		              getToolkit().beep(); 
		              ke.consume();  
		              } 
			}
		});
		
		tfZbkia.setBounds(93, 58, 121, 19);
		panel.add(tfZbkia);
		tfZbkia.setColumns(10);
		
		tfAbizena = new JTextField();
		tfAbizena.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent ke) {
				char c=ke.getKeyChar(); 
	              if(Character.isDigit(c)) { 
		              getToolkit().beep(); 
		              ke.consume(); 
		          }
		    }
		});
		
		tfAbizena.setBounds(93, 85, 121, 19);
		panel.add(tfAbizena);
		tfAbizena.setColumns(10);
		
		tfLanbidea = new JTextField();
		tfLanbidea.setBounds(93, 106, 121, 19);
		panel.add(tfLanbidea);
		
		tfLanbidea.setColumns(10);
		
		tfSoldata = new JTextField();
		tfSoldata.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent ke) {
				char c=ke.getKeyChar(); 
		         if(Character.isLetter(c)) { 
	              getToolkit().beep(); 
	              ke.consume();  
	              } 
			}
		});
		
		tfSoldata.setBounds(93, 133, 121, 19);
		panel.add(tfSoldata);
		tfSoldata.setColumns(10);
		
		tfKomisioa = new JTextField();
		tfKomisioa.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent ke) {
				char c=ke.getKeyChar(); 
		         if(Character.isLetter(c)) { 
	              getToolkit().beep(); 
	              ke.consume();  
	              } 
			}
		});
		
		tfKomisioa.setBounds(93, 160, 121, 19);
		panel.add(tfKomisioa);
		tfKomisioa.setColumns(10);
		
		btnSartu = new JButton("Sartu");
		btnSartu.setBounds(22, 203, 117, 25);
		panel.add(btnSartu);
		
		btnEzabatu = new JButton("Ezabatu");
		btnEzabatu.setBounds(186, 203, 117, 25);
		panel.add(btnEzabatu);
		
		btnAldatu = new JButton("Aldatu");
		btnAldatu.setBounds(360, 203, 117, 25);
		panel.add(btnAldatu);
		
		btnIrten = new JButton("Irten");
		btnIrten.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		
		btnIrten.setBounds(22, 255, 117, 25);
		panel.add(btnIrten);
		
		btnGarbitu = new JButton("Garbitu");
		btnGarbitu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				tfAbizena.setText("");
				tfKomisioa.setText("");
				tfLanbidea.setText("");
				tfSoldata.setText("");
				tfZbkia.setText("");
				tfData.setText("");

			}
		});
		btnGarbitu.setBounds(186, 255, 117, 25);
		panel.add(btnGarbitu);
		
		btnExtra = new JButton("Extra");
		btnExtra.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Aukeratu frame = new Aukeratu();
				frame.setVisible(true);
			}
		});
		btnExtra.setBounds(360, 255, 117, 25);
		panel.add(btnExtra);
		
		JLabel lblEnplegatuenGestioa = new JLabel("ENPLEGATUEN GESTIOA");
		lblEnplegatuenGestioa.setHorizontalAlignment(SwingConstants.CENTER);
		lblEnplegatuenGestioa.setFont(new Font("Dialog", Font.BOLD, 16));
		lblEnplegatuenGestioa.setBounds(12, 0, 231, 39);
		panel.add(lblEnplegatuenGestioa);
		
		JLabel lblAltaData = new JLabel("Alta data");
		lblAltaData.setBounds(261, 135, 70, 15);
		panel.add(lblAltaData);
		
		tfData = new JTextField();
		tfData.setBounds(338, 133, 139, 19);
		panel.add(tfData);
		tfData.setColumns(10);
		
	}

	public JTextField getTfZbkia() {
		return tfZbkia;
	}

	public void setTfZbkia(JTextField tfZbkia) {
		this.tfZbkia = tfZbkia;
	}

	public JTextField getTfAbizena() {
		return tfAbizena;
	}

	public void setTfAbizena(JTextField tfAbizena) {
		this.tfAbizena = tfAbizena;
	}

	public JTextField getTfLanbidea() {
		return tfLanbidea;
	}

	public void setTfLanbidea(JTextField tfLanbidea) {
		this.tfLanbidea = tfLanbidea;
	}

	public JTextField getTfSoldata() {
		return tfSoldata;
	}

	public void setTfSoldata(JTextField tfSoldata) {
		this.tfSoldata = tfSoldata;
	}

	public JTextField getTfKomisioa() {
		return tfKomisioa;
	}

	public void setTfKomisioa(JTextField tfKomisioa) {
		this.tfKomisioa = tfKomisioa;
	}

	public JTextField getTfData() {
		return tfData;
	}

	public void setTfData(JTextField tfData) {
		this.tfData = tfData;
	}

	public JComboBox getBoxDepart() {
		return boxDepart;
	}

	public void setBoxDepart(JComboBox boxDepart) {
		this.boxDepart = boxDepart;
	}

	public JComboBox getBoxZuzen() {
		return boxZuzen;
	}

	public void setBoxZuzen(JComboBox boxZuzen) {
		this.boxZuzen = boxZuzen;
	}
	
	
}