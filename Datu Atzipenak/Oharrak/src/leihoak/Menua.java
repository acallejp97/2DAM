package leihoak;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import eredua.OharrakKudeatu;
import kontroladorea.Menukontroladorea;

public class Menua extends JFrame  {

	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JButton btnGehituOharra;
	private JButton btnInprimatu;
	private JButton btnIrten;
	public OharrakKudeatu kudeatu = new eredua.OharrakKudeatu();

	public Menua() {
		Menukontroladorea kon = new Menukontroladorea();
		setTitle("MENU NAGUSIA");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		JButton btnKargatuMemorian = new JButton("Kargatu Memorian Fitxategitik");

		btnKargatuMemorian.addActionListener(kon);
		btnKargatuMemorian.setActionCommand("KARGATU");
		btnKargatuMemorian.setBounds(89, 32, 287, 25);
		contentPane.add(btnKargatuMemorian);

		btnGehituOharra = new JButton("Gehitu oharra");
		btnGehituOharra.addActionListener(kon);
		btnGehituOharra.setActionCommand("GEHITU");
		
		
		btnGehituOharra.setBounds(89, 69, 287, 25);
		contentPane.add(btnGehituOharra);

		JButton btnGordeOharra = new JButton("Gorde oharrak fitxategian");
		btnGordeOharra.addActionListener(kon);
		btnGordeOharra.setActionCommand("GORDE");
		btnGordeOharra.setBounds(89, 106, 287, 25);
		contentPane.add(btnGordeOharra);

		btnInprimatu = new JButton("Inprimatu");
		btnInprimatu.setBounds(89, 143, 287, 25);
		btnInprimatu.addActionListener(kon);
		btnInprimatu.setActionCommand("INPRIMATU");
		contentPane.add(btnInprimatu);

		btnIrten = new JButton("Irten");
		btnIrten.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dispose();
			}
		});

		btnIrten.setBounds(211, 206, 133, 25);

		contentPane.add(btnIrten);
	}

	

}
