package leihoak;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JDialog;
import javax.swing.JFormattedTextField;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;
import javax.swing.text.MaskFormatter;

import eredua.Oharra;
import eredua.OharrakKudeatu;

public class OharrenInprimakia extends JDialog implements ActionListener {

	private static final long serialVersionUID = 1L;
	private final JPanel contentPanel = new JPanel();
	private JFormattedTextField textUrtea;
	JComboBox<Object> comboHilabetea;
	JComboBox<Object> comboEguna;
	JComboBox<Object> comboOrdua;
	JComboBox<Object> comboMinutuak;
	private JFormattedTextField textNork;
	private JFormattedTextField textNori;
	private JTextField textTitulua;
	JTextArea textEdukia;
	
	public OharrenInprimakia(OharrakKudeatu kudeatu) {
		
		
		setModalityType(ModalityType.APPLICATION_MODAL);
		setModalExclusionType(ModalExclusionType.APPLICATION_EXCLUDE);
		setModal(true);
		setResizable(false);
		setTitle("OHARREN INPRIMAKIA");
		setBounds(100, 100, 576, 404);
		getContentPane().setLayout(new BorderLayout());
		contentPanel.setBorder(new EmptyBorder(5, 5, 5, 5));
		getContentPane().add(contentPanel, BorderLayout.CENTER);
		contentPanel.setLayout(null);

		JLabel lblData = new JLabel("Data:");
		lblData.setBounds(12, 25, 70, 15);
		contentPanel.add(lblData);

		try {
			MaskFormatter txantiloia= new MaskFormatter("####");
			textUrtea= new JFormattedTextField(txantiloia);
			textUrtea.setBounds(58, 23, 48, 19);
			contentPanel.add(textUrtea);
			textUrtea.setValue(new Integer("2017"));
			textUrtea.setColumns(4);
		} catch (Exception e) {
			// TODO: handle exception
		}
		
		

		JLabel label = new JLabel(":");
		label.setBounds(116, 23, 5, 15);
		contentPanel.add(label);

		comboHilabetea = new JComboBox<Object>();
		comboHilabetea.setModel(new DefaultComboBoxModel<Object>(new String[] { "Urtarrila", "Otsaila", "Martxoa",
				"Apirila", "Maiatza", "Ekaina", "Uztaila", "Abuztua", "Iraila", "Urria", "Azaroa", "Abendua" }));
		comboHilabetea.setBounds(139, 20, 97, 24);
		contentPanel.add(comboHilabetea);

		JLabel label_1 = new JLabel(":");
		label_1.setBounds(254, 25, 5, 15);
		contentPanel.add(label_1);

		comboEguna = new JComboBox<Object>();
		comboEguna.setModel(new DefaultComboBoxModel<Object>(new String[] { "01", "02", "03", "04", "05", "06", "07",
				"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24",
				"25", "26", "27", "28", "29", "30", "31" }));
		comboEguna.setBounds(277, 20, 48, 24);
		contentPanel.add(comboEguna);

		JLabel lblOrdua = new JLabel("Ordua:");
		lblOrdua.setBounds(12, 72, 70, 15);
		contentPanel.add(lblOrdua);

		comboOrdua = new JComboBox<Object>();
		comboOrdua.setModel(new DefaultComboBoxModel<Object>(
				new String[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" }));
		comboOrdua.setBounds(74, 67, 47, 24);
		contentPanel.add(comboOrdua);

		JLabel label_2 = new JLabel(":");
		label_2.setBounds(152, 72, -22, 15);
		contentPanel.add(label_2);

		JLabel label_3 = new JLabel(":");
		label_3.setBounds(139, 72, 5, 15);
		contentPanel.add(label_3);

		comboMinutuak = new JComboBox<Object>();
		comboMinutuak.setModel(new DefaultComboBoxModel<Object>(
				new String[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15",
						"16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31",
						"32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47",
						"48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "00" }));
		comboMinutuak.setBounds(152, 67, 47, 24);
		contentPanel.add(comboMinutuak);

		JLabel lblNori = new JLabel("Nork:");
		lblNori.setBounds(12, 155, 70, 15);
		contentPanel.add(lblNori);

		JLabel label_4 = new JLabel("Nori:");
		label_4.setBounds(12, 121, 70, 15);
		contentPanel.add(label_4);

		JLabel lblTitulua = new JLabel("Titulua:");
		lblTitulua.setBounds(12, 182, 70, 15);
		contentPanel.add(lblTitulua);

		JLabel lblEdukia = new JLabel("Edukia:");
		lblEdukia.setBounds(12, 209, 70, 15);
		contentPanel.add(lblEdukia);

		try {
			MaskFormatter txantiloia= new MaskFormatter("************************");
			textNork= new JFormattedTextField(txantiloia);
			textNork.setBounds(58, 119, 201, 19);
			textNork.setColumns(24);
			contentPanel.add(textNork);
			} catch (Exception e) {
		}
		
	

		
		try {
			MaskFormatter txantiloia= new MaskFormatter("************************");
			textNori= new JFormattedTextField(txantiloia);
			textNori.setBounds(68, 153, 201, 19);
			textNork.setColumns(24);
			contentPanel.add(textNori);		
		} catch (Exception e) {
		}
		

		textTitulua = new JTextField();
		textTitulua.setColumns(10);
		textTitulua.setBounds(74, 182, 201, 19);
		contentPanel.add(textTitulua);

		textEdukia = new JTextArea();
		textEdukia.setBounds(74, 209, 383, 118);
		contentPanel.add(textEdukia);
		this.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		
		
			JPanel buttonPane = new JPanel();
			buttonPane.setLayout(new FlowLayout(FlowLayout.RIGHT));
			getContentPane().add(buttonPane, BorderLayout.SOUTH);
			{
				JButton GordeButton = new JButton("Gorde");
				GordeButton.addActionListener((ActionListener) this);

				buttonPane.add(GordeButton);
				getRootPane().setDefaultButton(GordeButton);
			}
			{
				JButton cancelButton = new JButton("Utzi");
				cancelButton.addActionListener(new ActionListener() {

					@Override
					public void actionPerformed(ActionEvent arg0) {
						dispose();
					}

				});
				buttonPane.add(cancelButton);
			}
		
		this.setVisible(true);
	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		 Oharra OharBerria= new Oharra();
		
		OharBerria.setData(textUrtea.getText() + "-" + comboHilabetea.getSelectedIndex() + 1 + "-"
				+ comboEguna.getSelectedItem().toString());
		comboOrdua.getSelectedItem().toString();
		comboMinutuak.getSelectedItem().toString();
		OharBerria.setOrdua(comboOrdua.getSelectedItem().toString() + ":" + comboMinutuak.getSelectedItem().toString());
		OharBerria.setNork(textNork.getText());
		OharBerria.setNori(textNori.getText());
		OharBerria.setTitulua(textTitulua.getText());
		OharBerria.setEdukia(textEdukia.getText());
		System.out.println(OharBerria.toString());
		OharrakKudeatu.gehituOharra(OharBerria);
	}

	

}
