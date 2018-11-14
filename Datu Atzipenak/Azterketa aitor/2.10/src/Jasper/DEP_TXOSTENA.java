package Jasper;

import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperCompileManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.view.JasperViewer;
import java.sql.Connection;

import konektatu.konexioa;
public class DEP_TXOSTENA {
    
    public DEP_TXOSTENA() {
        
        String reportSource = "Coffee_.jrxml";
        
try {
JasperReport jasperReport = JasperCompileManager.compileReport(reportSource);
        
            konexioa konexioa=new konexioa();
            Connection kon=konexioa.getKonekzioa();
            JasperPrint NireTxostena = JasperFillManager.fillReport(jasperReport, null, kon);
            //Pantailatik ikuskatu
            JasperViewer.viewReport(NireTxostena,false);
                        
        }   catch (JRException ex) {
            System.out.println(" Jasper Errorea.");
            ex.printStackTrace();
        }


}

}
