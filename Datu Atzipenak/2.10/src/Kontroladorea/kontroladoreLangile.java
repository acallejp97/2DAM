package Kontroladorea;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Date;

import javax.swing.JOptionPane;

import Lehioak.Langile;
import konektatu.konexioa;

public class kontroladoreLangile extends Langile implements ActionListener{

	protected Langile view;
	konexioa kon=new konexioa();
	Date hoy= new Date(); 
	
	
	public kontroladoreLangile(Langile view) throws SQLException{
		super();
		this.view=view;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		CallableStatement cs =null;
		Connection conexion = kon.getKonekzioa();
		
		String komandoa=e.getActionCommand();
		String dep;
		try {
			
			//if this.view.get
			if(this.view.getTfKomisioa().getText()==null) 
			this.view.getTfKomisioa().setText("0");
			if (this.view.getTfData().getText()==null) 
			this.view.getTfData().setText(hoy.getYear()+"-"+hoy.getMonth()+"-"+hoy.getDay());
			
				
		switch (komandoa) {
		case "Sartu":
			
			cs=conexion.prepareCall("{CALL Insertar (?,?,?,?,?,?,?,?)}");
			cs.setInt(1, Integer.parseInt(this.view.getTfZbkia().getText()));
			cs.setString(2, this.view.getTfAbizena().getText());
			cs.setString(3, this.view.getTfLanbidea().getText());
			cs.setString(4, this.view.getTfSoldata().getText());
			cs.setString(5, this.view.getTfKomisioa().getText());
			
			cs.setInt(6, hartu(this.view.getBoxZuzen().getSelectedItem().toString()));;
			cs.setString(7, this.view.getTfData().getText());
			cs.setInt(8, hartu(this.view.getBoxDepart().getSelectedItem().toString()));;
			
			cs.execute();
			
			break;
		case "Ezabatu":
			cs=conexion.prepareCall("{CALL Ezabatu (?)}");
			cs.setInt(1, Integer.parseInt(this.view.getTfZbkia().getText()));
			cs.execute();
			
			break;
		case "Aldatu":
			cs=conexion.prepareCall("{CALL Aldatu (?,?,?,?,?,?,?,?)}");
			cs.setInt(1, Integer.parseInt(this.view.getTfZbkia().getText()));
			cs.setString(2, this.view.getTfAbizena().getText());
			cs.setString(3, this.view.getTfLanbidea().getText());
			cs.setString(4, this.view.getTfSoldata().getText());
			cs.setString(5, this.view.getTfKomisioa().getText());
			
			cs.setInt(6, hartu(this.view.getBoxZuzen().getSelectedItem().toString()));;
			cs.setString(7, this.view.getTfData().getText());
			cs.setInt(8, hartu(this.view.getBoxDepart().getSelectedItem().toString()));;
			
			cs.execute();
			
			break;
			
		case "Kontsulta":
			if (this.view.getTfZbkia().getText()!=null) {
			cs=conexion.prepareCall("{CALL select_to (?,?,?,?,?,?,?,?)}");
			
			
			
			cs.setInt(1, Integer.parseInt(this.view.getTfZbkia().getText()));
			cs.registerOutParameter(2, java.sql.Types.VARCHAR);
			cs.registerOutParameter(3, java.sql.Types.VARCHAR);
			cs.registerOutParameter(4, java.sql.Types.VARCHAR);
			cs.registerOutParameter(5, java.sql.Types.VARCHAR);
			cs.registerOutParameter(6, java.sql.Types.INTEGER);
			cs.registerOutParameter(7, java.sql.Types.DATE);
			cs.registerOutParameter(8, java.sql.Types.INTEGER);
			
			cs.execute();
			
			this.view.getTfAbizena().setText(cs.getString(2));
			this.view.getTfLanbidea().setText(cs.getString(3));
			this.view.getTfSoldata().setText(cs.getString(4));
			this.view.getTfKomisioa().setText(cs.getString(5));
			
			dep = cs.getInt(6) + "/" + consulta(cs.getInt(6)); 
			this.view.getBoxZuzen().setSelectedItem(dep);
			
			this.view.getTfData().setText(cs.getString(7));
			
			dep = cs.getInt(8) + "/" + consulta(cs.getInt(8)); 
			this.view.getBoxDepart().setSelectedItem(dep);
			
			}else {
				
			}
			
			break;
		
		}
		
		
		
		}catch (java.sql.SQLException ex) {
			JOptionPane.showMessageDialog(null,"Sartu balore guztiak");
		}catch (java.lang.NumberFormatException ex) {
			JOptionPane.showMessageDialog(null,"Sartu zenbaki bat");
		}
		
	}
	public String consulta(int num) throws SQLException {
		String nombre="";
		Connection conexion = kon.getKonekzioa();
		Statement stm=conexion.createStatement();
		if (num<100) {
			ResultSet rs=stm.executeQuery("Select dnombre FROM departamentos WHERE dept_no like "+num+" ;");
			while(rs.next()) {nombre=rs.getString(1);}
		}else {
			ResultSet rs=stm.executeQuery("Select apellido FROM empleados where emp_no like "+num+" ;");
			while(rs.next()) {nombre=rs.getString(1);}		}
		
		
		
		return nombre;
	}
	public int hartu(String esal) {
		int zen=0;
		String zenb[];
		zenb=esal.split("/");
		zen=Integer.parseInt(zenb[0]);
		return zen;
		
	}
	
}