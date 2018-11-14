package azterketa;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.StringTokenizer;

public class Ariketa1 {
	private String formatoa;

	public static void main(String[] args) {
		String formatoa = "|%1$-4s" //%1$ primer puesto. '|' se alinea a la izquierda y por eso se pone a la izquierda y el 4 son los numeros minimos de caracteres. la 's' es que lo escriba tal y como esta, sin mayuscula o minuscula
				+ "|%2$-15S" //al menos 15 caracteres todo en matuscula
				+ "|%3$-15S"
				+ "|%n"; //pasar al siguiente
		try (BufferedReader br = new BufferedReader(new FileReader("departamentuak.csv"))) {
			String lerroa;
			while ((lerroa = br.readLine()) != null) {
				lerroa = lerroa.replace(" ", "");
				StringTokenizer st = new StringTokenizer(lerroa, ",");
				switch (st.countTokens()) {
				case 1:
					System.out.printf(formatoa, st.nextToken(), "", "");
					break;
				case 2:
					String[] tokenak = lerroa.split(",,");
					if (tokenak.length > 1)
						System.out.printf(formatoa, st.nextToken(), "", st.nextToken());
					else
						System.out.printf(formatoa, st.nextToken(), st.nextToken(), "");
					break;
				case 3:
					System.out.printf(formatoa, st.nextToken(), st.nextToken(), st.nextToken());
					break;
				default:
					break;
				}
			}
		} catch (IOException e) {
			System.out.println("S/Iko errorea gertatu egin da.");
		}
	}
}
