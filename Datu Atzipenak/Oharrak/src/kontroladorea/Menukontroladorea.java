package kontroladorea;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import Lehioak.*;
public class menukontroladorea implements ActionListener{
Gehitu kar=new Gehitu();
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		String komandoa=e.getActionCommand();
		switch (komandoa) {
		case "Kargatu":
			System.out.println("kargatu oharrak");
			kar.setVisible(true);
			break;
		case "Gehitu":
			System.out.println("Gehitu oharrak");
			break;
		case "Gorde":
			System.out.println("Gorde oharrak");
			break;
		case "Inprimatu":
			System.out.println("Inprimatu");
			break;

		default:
			System.out.println("Irtetzen");
			System.exit(0);
			break;
		}
		
	}

}
