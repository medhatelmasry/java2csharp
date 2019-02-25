import java.util.Scanner;
import com.dev.Circle;

public class Program {
  public static void main(String[] args) {	
    Scanner scanner = new Scanner(System.in);
    System.out.print("Enter a radius: ");
    String strRadius = scanner.nextLine();
    scanner.close();
    double dblRadius = 0;
    try {
      dblRadius = Double.parseDouble(strRadius);
    } catch (NumberFormatException nfe) {
      System.out.println("You must enter a number!!");
      return;
    }
    double area = Circle.Area(dblRadius);
    String output1 = String.format("The area of a circle with radius %s is %.2f.", strRadius, area);
    System.out.println(output1);

    double perimeter = Circle.Perimeter(dblRadius);
    String output2 = String.format("The perimeter of a circle with radius %s is %.2f.", strRadius, perimeter);
    System.out.println(output2);

  }
}
