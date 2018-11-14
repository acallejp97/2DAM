package kontroladorea;

import java.awt.EventQueue;

import leihoak.Menua;

class Nagusia {

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					
					Menua frame = new Menua();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

}
