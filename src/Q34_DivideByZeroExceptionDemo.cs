using System;

namespace DotNet
{
  // Q34: Divide by Zero exception handling demo
  public class Q34_DivideByZeroExceptionDemo
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q34 Divide by Zero Demo --");
      try
      {
        Console.Write("Enter dividend: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter divisor: ");
        int b = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Result: {a / b}");
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("Cannot divide by zero.");
      }
      catch (FormatException)
      {
        Console.WriteLine("Invalid number format.");
      }
    }
  }
}
