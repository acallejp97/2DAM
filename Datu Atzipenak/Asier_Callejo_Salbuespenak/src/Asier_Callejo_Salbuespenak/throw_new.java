package Asier_Callejo_Salbuespenak;

public class throw_new {
	static void adibideproz() {
        try {
            throw new NullPointerException( "adibidea" );
        } catch( NullPointerException e ) {
            System.out.println( "Salbuespena hartuta" );
            throw e;
            }
        }

    public static void main() {
        try {
            adibideproz();
        } catch( NullPointerException e ) {
            System.out.println( "Hartuta berriz: " + e );
            }
     }
}
