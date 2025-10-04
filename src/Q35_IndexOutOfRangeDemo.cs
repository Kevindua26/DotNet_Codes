using System;

namespace DotNet
{
  // Q35: IndexOutOfRangeException demo
  public class Q35_IndexOutOfRangeDemo
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q35 IndexOutOfRangeException Demo --");
      try
      {
        int[] arr = new int[3] { 1, 2, 3 };
        Console.WriteLine(arr[5]);
      }
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine($"Index out of range: {ex.Message}");
      }
    }
  }
}
