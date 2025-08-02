// Q6: Write a C# Sharp program to check whether entered number is even or odd.
using System;

namespace DotNet
{
  public class Q6_EvenOdd
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter a number: ");
      int num = int.Parse(Console.ReadLine());
      if (num % 2 == 0)
        Console.WriteLine($"{num} is Even.");
      else
        Console.WriteLine($"{num} is Odd.");
    }
  }
}
