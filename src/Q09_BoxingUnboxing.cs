// Q9: Write a Program in C# to demonstrate boxing and Unboxing.
using System;

namespace DotNet
{
  public class Q9_BoxingUnboxing
  {
    public static void Main(string[] args)
    {
      int num = 123;
      object box = num; // Boxing
      int unbox = (int)box; // Unboxing
      Console.WriteLine($"Boxed value: {box}");
      Console.WriteLine($"Unboxed value: {unbox}");
    }
  }
}
