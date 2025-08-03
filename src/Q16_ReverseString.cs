// Q16. Write a program to reverse a given string using C#.
using System;

namespace DotNet
{
  public class Q16_ReverseString
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter a string: ");
      string input = Console.ReadLine();
      char[] arr = input.ToCharArray();
      Array.Reverse(arr);
      string reversed = new string(arr);
      Console.WriteLine($"Reversed string: {reversed}");
    }
  }
}
