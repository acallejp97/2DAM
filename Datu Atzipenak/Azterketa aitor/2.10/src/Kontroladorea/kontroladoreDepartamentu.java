package Kontroladorea;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Statement;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.swing.JOptionPane;

import Lehioak.Departamentu;
import konektatu.konexioa;

public class kontroladoreDepartamentu extends Departamentu implements ActionListener{
	
	protected Departamentu view;
	konexioa kon=new konexioa();
	
	int kopuru;
	int kalk=0;
	int[] kode;
	
	
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
			Statement stm= conexion.createStatement();
			ResultSet rs=stm.executeQuery("select count(*) dept_no from departamentos");
			while (rs.next()) {
				kopuru=rs.getInt(1);		
			}
			
			kode=new int[kopuru];
			int i=0;
			ResultSet rw=stm.executeQuery("select dept_no from departamentos");
			while (rw.next()) {
			kode[i]=rw.getInt(1);
			i++;
			}
			switch (e.getActionCommand()) {
			case "hurrengo":
				if (kalk<kode.length-1) {
				kalk++;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode[kalk]);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode[kalk]));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				
				}
				break;

			
			case "aurreko":
				if (kalk>0) {
				kalk--;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode[kalk]);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode[kalk]));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				
				}
				break;
			case "lehenengo":
				kalk=0;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode[0]);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode[kalk]));
				this.view.getTfIzena().setText(cs.getString(2));
				this.view.getTfKokapena().setText(cs.getString(3));
				break;
				
				
			case "azkenengo":
				kalk=kode.length-1;
				cs=conexion.prepareCall("{CALL departamentuak (?,?,?)}");
				cs.setInt(1, kode[kalk]);
				cs.registerOutParameter(2, java.sql.Types.VARCHAR);
				cs.registerOutParameter(3, java.sql.Types.VARCHAR);
				
				cs.executeQuery();
				
				this.view.getTfKodea().setText(String.valueOf(kode[kalk]));
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
