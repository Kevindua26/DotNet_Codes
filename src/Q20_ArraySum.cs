// Q20. WAP in C# Sharp to find the sum of all elements of the array.
using System;

namespace DotNet
{
  public class Q20_ArraySum
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter number of elements: ");
      int n = int.Parse(Console.ReadLine());
      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
        Console.Write($"Element {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine());
      }
      int sum = 0;
      foreach (int val in arr)
        sum += val;
      Console.WriteLine($"Sum of all elements: {sum}");
    }
  }
}
