using System;
using System.Collections.Generic;

namespace DotNet
{
  // Q39: Read names and sort case-insensitively
  public class Q39_SortNames
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q39 Sort Names --");
      Console.Write("How many names? ");
      if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) return;
      var names = new List<string>(n);
      for (int i = 0; i < n; i++)
      {
        Console.Write($"Name {i + 1}: ");
        names.Add(Console.ReadLine() ?? string.Empty);
      }
      names.Sort(StringComparer.OrdinalIgnoreCase);
      Console.WriteLine("Sorted names:");
      names.ForEach(Console.WriteLine);
    }
  }
}
