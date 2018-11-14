package ariketa;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.SQLException;

import konektatu.konexioa;

public class ariketa {

	public static void main(String[] args) {
		
		   
		   Connection conn = null;
		   CallableStatement stmt = null;
		   konexioa kon=new konexioa();
			Connection conexion=kon.getKonekzioa();
				
		   try{

		      //STEP 4: Execute a query
		      System.out.println("Creating statement...");
		      String sql = "{call u2_8 (?, ?, ?)}";
		      stmt = conexion.prepareCall(sql);
		      
		      //Bind IN parameter first, then bind OUT parameter
		      int dept_no = 10;
		      stmt.setInt(1, dept_no); 
		      stmt.registerOutParameter(2, java.sql.Types.FLOAT);
		      stmt.registerOutParameter(3, java.sql.Types.INTEGER);
		      
		      //Use execute method to run stored procedure.
		      System.out.println("Executing stored procedure..." );
		      stmt.execute();

		      //Retrieve employee name with getXXX method
		      double batezbeste = stmt.getDouble(2);
		      int emp_kop = stmt.getInt(3);
		      System.out.println("Batezbestekoa: "+batezbeste+" Empleatu kopurua: "+emp_kop);
		               

		      stmt.close();
		      conexion.close();
		   }catch(SQLException se){
		      //Handle errors for JDBC
		      se.printStackTrace();
		   }catch(Exception e){
		      //Handle errors for Class.forName
		      e.printStackTrace();
		   }finally{
		      //finally block used to close resources
		      try{
		         if(stmt!=null)
		            stmt.close();
		      }catch(SQLException se2){
		      }// nothing we can do
		      try{
		         if(conn!=null)
		            conn.close();
		      }catch(SQLException se){
		         se.printStackTrace();
		      }//end finally try
		   }//end try
		   System.out.println("Goodbye!");
	}//end main
	}// fin de main
			 