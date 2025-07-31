// Write a C# Sharp program that takes a number as input and print its multiplication table.
using System;

namespace DotNet
{
  public class Q1_MultiplicationTable
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter a number: ");
      int number = int.Parse(Console.ReadLine());
      Console.WriteLine($"Multiplication table for {number}:");
      for (int i = 1; i <= 10; i++)
      {
          Console.WriteLine($"{number} x {i} = {number * i}");
      }
    }
  }
}
