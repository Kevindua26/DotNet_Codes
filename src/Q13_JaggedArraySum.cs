// Q13. Find the sum of all the elements present in a jagged array of 3 in n arrays.
using System;

namespace DotNet
{
  public class Q13_JaggedArraySum
  {
    public static void Main(string[] args)
    {
      int[][] jagged = new int[3][];
      for (int i = 0; i < 3; i++)
      {
        Console.Write($"Enter number of elements for array {i + 1}: ");
        int n = int.Parse(Console.ReadLine());
        jagged[i] = new int[n];
        for (int j = 0; j < n; j++)
        {
          Console.Write($"Element {j + 1}: ");
          jagged[i][j] = int.Parse(Console.ReadLine());
        }
      }
      int sum = 0;
      foreach (var arr in jagged)
        foreach (var val in arr)
          sum += val;
      Console.WriteLine($"Sum of all elements: {sum}");
    }
  }
}
