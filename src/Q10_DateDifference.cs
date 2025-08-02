// Q10: Write a Program in C# to find difference between two dates.
using System;

namespace DotNet
{
  public class Q10_DateDifference
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter first date (yyyy-mm-dd): ");
      DateTime date1 = DateTime.Parse(Console.ReadLine());
      Console.Write("Enter second date (yyyy-mm-dd): ");
      DateTime date2 = DateTime.Parse(Console.ReadLine());
      TimeSpan diff = date2 - date1;
      Console.WriteLine($"Difference: {Math.Abs(diff.TotalDays)} days");
    }
  }
}
