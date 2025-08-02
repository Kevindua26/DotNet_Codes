// Q8: Write a Program in C# to find the roots of Quadratic Equation.
using System;

namespace DotNet
{
  public class Q8_QuadraticRoots
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter coefficient a: ");
      double a = double.Parse(Console.ReadLine());
      Console.Write("Enter coefficient b: ");
      double b = double.Parse(Console.ReadLine());
      Console.Write("Enter coefficient c: ");
      double c = double.Parse(Console.ReadLine());

      double discriminant = b * b - 4 * a * c;
      if (discriminant > 0)
      {
        double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine($"Roots are real and different: {root1}, {root2}");
      }
      else if (discriminant == 0)
      {
        double root = -b / (2 * a);
        Console.WriteLine($"Roots are real and same: {root}");
      }
      else
      {
        double realPart = -b / (2 * a);
        double imagPart = Math.Sqrt(-discriminant) / (2 * a);
        Console.WriteLine($"Roots are complex: {realPart} + {imagPart}i, {realPart} - {imagPart}i");
      }
    }
  }
}
