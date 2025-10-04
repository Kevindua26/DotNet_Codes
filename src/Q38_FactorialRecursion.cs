using System;

namespace DotNet
{
  // Q38: Factorial using recursion
  public class Q38_FactorialRecursion
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q38 Factorial (recursion) --");
      Console.Write("Enter a non-negative integer: ");
      if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
      {
        Console.WriteLine($"Factorial of {n} is {Factorial(n)}");
      }
      else Console.WriteLine("Invalid input");
    }

    static long Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
  }
}
