// Q5: Write a C# Sharp program that takes a number and a width as input and displays a triangle of that width using that number.
using System;

namespace DotNet
{
  public class Q5_Triangle
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter the number to use: ");
      int num = int.Parse(Console.ReadLine());
      Console.Write("Enter the width of the triangle: ");
      int width = int.Parse(Console.ReadLine());
      for (int i = 1; i <= width; i++)
      {
        for (int j = 0; j < i; j++)
        {
          Console.Write(num + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
