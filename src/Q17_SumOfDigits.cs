// Q17. WAP in C# to get a number and display the sum of its digits.
using System;

namespace DotNet
{
  public class Q17_SumOfDigits
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter a number: ");
      int num = int.Parse(Console.ReadLine());
      int sum = 0;
      while (num != 0)
      {
        sum += num % 10;
        num /= 10;
      }
      Console.WriteLine($"Sum of digits: {sum}");
    }
  }
}
