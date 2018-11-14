package Asier_Callejo_Scanner3;



import java.util.Scanner;
    class AssignmentOneTest {

public static void main(String[] args)
{
    Scanner kb = new Scanner(System.in);

    //       System.out.printf("$%4.2f for each %s ", price, item);
    //       System.out.printf("\nThe total is: $%4.2f ", total);

    //process for item one
    System.out.println("Please enter in your first item");
    String item = kb.nextLine();
    System.out.println("Please enter the quantity for this item");
    int quantity = Integer.parseInt(kb.nextLine());
    System.out.println("Please enter in the price of your item");
    double price = Double.parseDouble(kb.nextLine());




    //process for item two
    System.out.println("Please enter in your second item");
    String item2 = kb.nextLine();
    System.out.println("Please enter the quantity for this item");
    int quantity2 = Integer.parseInt(kb.nextLine());
    System.out.print("Please enter in the price of your item");
    double price2 =Double.parseDouble(kb.nextLine());
    double total2 = quantity2*price2;
    //       System.out.printf("$%4.2f for each %s ", price2, item2);
    //       System.out.printf("\nThe total is: $%4.2f ", total2);

    //process for item three
    System.out.println("Please enter in your third item");
    String item3 = kb.nextLine();
    System.out.println("Please enter the quantity for this item");
    int quantity3 = Integer.parseInt(kb.nextLine());
    System.out.println("Please enter in the price of your item");
    double price3 = Double.parseDouble(kb.nextLine());
    double total3 = quantity3*price3;
    //       System.out.printf("$%4.2f for each %s ", price3, item3);
    //       System.out.printf("\nThe total is: $%4.2f ", total3);


    double total = quantity*price;

    double grandTotal = total + total2 + total3;
    double salesTax = grandTotal*(.0625);
    double grandTotalTaxed = grandTotal + salesTax;


    String amount = "Quantity";
    String amount1 = "Price";
    String amount2 = "Total";
    String taxSign = "%";

    System.out.printf("\nYour bill: ");
    System.out.printf("\n\nItem");
    System.out.printf("%28s %11s %11s", "Quantity", "Price", "Total");

    //complete item one format
    System.out.printf("\n%-30s", item);
    System.out.printf("%-10d", (int)quantity);
    System.out.printf("%-10.2f", (float)price);
    System.out.printf("  " + "%-10.2f", (float)total);

    //complete item two format
    System.out.printf("\n%-30s", item2);
    System.out.printf("%-10d", (int)quantity2);
    System.out.printf("%-10.2f", (float)price2);
    System.out.printf("  " + "%-10.2f", (float)total2);
	}
}