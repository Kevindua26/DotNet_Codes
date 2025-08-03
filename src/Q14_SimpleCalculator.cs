// Q14. Design a simple calculator using Switch Statement in C#.
using System;

namespace DotNet
{
  public class Q14_SimpleCalculator
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter first number: ");
      double num1 = double.Parse(Console.ReadLine());
      Console.Write("Enter operator (+, -, *, /): ");
      char op = Console.ReadLine()[0];
      Console.Write("Enter second number: ");
      double num2 = double.Parse(Console.ReadLine());

      switch (op)
      {
        case '+': Console.WriteLine($"Result: {num1 + num2}"); break;
        case '-': Console.WriteLine($"Result: {num1 - num2}"); break;
        case '*': Console.WriteLine($"Result: {num1 * num2}"); break;
        case '/':
          if (num2 != 0)
            Console.WriteLine($"Result: {num1 / num2}");
          else
            Console.WriteLine("Cannot divide by zero.");
          break;
        default: Console.WriteLine("Invalid operator."); break;
      }
    }
  }
}
