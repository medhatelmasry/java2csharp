using System;
using com.dev;

public class Program {
  public static void Main(String[] args) {	
    Console.Write("Enter a radius: ");
    String strRadius = Console.ReadLine();
    double dblRadius = 0;
    try {
      dblRadius = double.Parse(strRadius);
    } catch (FormatException) {
      Console.WriteLine("You must enter a number!!");
      return;
    }
    double area = Circle.Area(dblRadius);
    double perimeter = Circle.Perimeter(dblRadius);
    String output1 = $"The area of a circle with radius {strRadius} is {area:#.##}.";
    Console.WriteLine(output1);
    String output2 = $"The perimeter of a circle with radius {strRadius} is {perimeter:#.##}.";
    Console.WriteLine(output2);

  }
}
