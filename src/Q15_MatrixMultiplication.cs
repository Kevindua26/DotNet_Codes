// Q15. Write a Program in C# to multiply two matrices using Rectangular arrays.
using System;

namespace DotNet
{
  public class Q15_MatrixMultiplication
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter rows of first matrix: ");
      int r1 = int.Parse(Console.ReadLine());
      Console.Write("Enter columns of first matrix: ");
      int c1 = int.Parse(Console.ReadLine());
      Console.Write("Enter rows of second matrix: ");
      int r2 = int.Parse(Console.ReadLine());
      Console.Write("Enter columns of second matrix: ");
      int c2 = int.Parse(Console.ReadLine());

      if (c1 != r2)
      {
        Console.WriteLine("Matrix multiplication not possible.");
        return;
      }

      int[,] mat1 = new int[r1, c1];
      int[,] mat2 = new int[r2, c2];
      int[,] result = new int[r1, c2];

      Console.WriteLine("Enter elements of first matrix:");
      for (int i = 0; i < r1; i++)
        for (int j = 0; j < c1; j++)
          mat1[i, j] = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter elements of second matrix:");
      for (int i = 0; i < r2; i++)
        for (int j = 0; j < c2; j++)
          mat2[i, j] = int.Parse(Console.ReadLine());

      for (int i = 0; i < r1; i++)
        for (int j = 0; j < c2; j++)
          for (int k = 0; k < c1; k++)
            result[i, j] += mat1[i, k] * mat2[k, j];

      Console.WriteLine("Resultant Matrix:");
      for (int i = 0; i < r1; i++)
      {
        for (int j = 0; j < c2; j++)
          Console.Write(result[i, j] + " ");
        Console.WriteLine();
      }
    }
  }
}
