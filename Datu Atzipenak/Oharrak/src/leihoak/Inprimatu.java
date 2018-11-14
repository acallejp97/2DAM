package leihoak;

import java.awt.BorderLayout;
import java.awt.FlowLayout;

import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Inprimatu extends JDialog {

	/**
	 * Launch the application.
	
	public static void main(String[] args) {
		try {
			String testua="\"Bla,bla,bla,Bla,bla,bla,\n";
			for (int i = 0; i < 100; i++) {
				testua+="\"Bla,bla,bla,Bla,bla,bla,\n";
			}
			Inprimatu dialog = new Inprimatu(testua);
			
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	
	 * Create the dialog.
	 */
	public Inprimatu(String testua) {
		setTitle("INPRIMATZE LEIHOA");
		setResizable(false);
		setModal(true);
		setBounds(100, 100, 510, 759);
		getContentPane().setLayout(null);
		
			JPanel buttonPane = new JPanel();
			buttonPane.setBounds(0, 687, 495, 35);
			buttonPane.setLayout(new FlowLayout(FlowLayout.RIGHT));
			getContentPane().add(buttonPane);
			{
				JButton cancelButton = new JButton("Irten");
				cancelButton.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						dispose();
					}
				});
				cancelButton.setActionCommand("");
				buttonPane.add(cancelButton);
			}
			
			JScrollPane scrollPane = new JScrollPane();
			scrollPane.setBounds(10, 2, 495, 673);
			getContentPane().add(scrollPane);
			
			JTextArea txtrBlablabla = new JTextArea();
			
			
			txtrBlablabla.setText(testua);
			txtrBlablabla.setEditable(false);
			txtrBlablabla.setColumns(40);
			scrollPane.setViewportView(txtrBlablabla);
			this.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
			this.setVisible(true);
		
	}
}
