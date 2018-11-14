package Kontroladorea;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;

import javax.swing.JOptionPane;

import Lehioak.Departamentu;
import konektatu.konexioa;

public class kontroladoreDepartamentu extends Departamentu implements ActionListener{
	
	protected Departamentu view;
	konexioa kon=new konexioa();
	int kode=10;

	public kontroladoreDepartamentu(Departamentu view) throws SQLException{
		super();
		this.view=view;
	}
	
	@Override
	public void actionPerformed(ActionEvent e){
		// TODO Auto-generated method stub
		CallableStatement cs=null;
		Connection conexion = kon.getKonekzioa();
		try {
			switch (e.getActionCommand()) {
			case "hurrengo":
				if (kode!=40) {
					kode+=10;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				}
				break;

			
			case "aurreko":
				if (kode!=10) {
					kode-=10;
				 
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				}
				break;
			case "lehenengo":
				kode=10;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				break;
				
				
			case "azkenengo":
				kode=40;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				break;
			}
			
		
		}catch (java.sql.SQLException ex) {
			JOptionPane.showMessageDialog(null,"Sartu balore guztiak");
		}catch (java.lang.NumberFormatException ex) {
			JOptionPane.showMessageDialog(null,"Sartu zenbaki bat");
		}
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
