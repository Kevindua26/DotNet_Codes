// Q18. WAP in C# to get a number and display the number with its reverse, check whether a number is Palindrome or not.
using System;

namespace DotNet
{
  public class Q18_Palindrome
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter a number: ");
      int num = int.Parse(Console.ReadLine());
      int original = num, reversed = 0;
      while (num != 0)
      {
        reversed = reversed * 10 + num % 10;
        num /= 10;
      }
      Console.WriteLine($"Original: {original}, Reversed: {reversed}");
      if (original == reversed)
        Console.WriteLine("Palindrome");
      else
        Console.WriteLine("Not Palindrome");
    }
  }
}
