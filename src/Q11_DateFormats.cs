// Q11. WAP in C# to display dates in various formats.
using System;

namespace DotNet
{
  public class Q11_DateFormats
  {
    public static void Main(string[] args)
    {
      DateTime now = DateTime.Now;
      Console.WriteLine($"Default: {now}");
      Console.WriteLine($"Short Date: {now.ToShortDateString()}");
      Console.WriteLine($"Long Date: {now.ToLongDateString()}");
      Console.WriteLine($"Short Time: {now.ToShortTimeString()}");
      Console.WriteLine($"Long Time: {now.ToLongTimeString()}");
      Console.WriteLine($"Custom: {now:dd-MM-yyyy HH:mm:ss}");
    }
  }
}
