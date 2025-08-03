// Q12. Write a C# Sharp program to find whether a given year is a leap year or not.
using System;

namespace DotNet
{
  public class Q12_LeapYear
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter a year: ");
      int year = int.Parse(Console.ReadLine());
      if (DateTime.IsLeapYear(year))
        Console.WriteLine($"{year} is a leap year.");
      else
        Console.WriteLine($"{year} is not a leap year.");
    }
  }
}
