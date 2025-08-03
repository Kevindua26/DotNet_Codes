// Q19. WAP concatenate two String, find sub-String and replace sub-String.
using System;

namespace DotNet
{
  public class Q19_StringOps
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter first string: ");
      string str1 = Console.ReadLine();
      Console.Write("Enter second string: ");
      string str2 = Console.ReadLine();

      string concat = str1 + str2;
      Console.WriteLine($"Concatenated: {concat}");

      Console.Write("Enter substring to find: ");
      string sub = Console.ReadLine();
      int idx = concat.IndexOf(sub);
      if (idx != -1)
        Console.WriteLine($"Substring found at index: {idx}");
      else
        Console.WriteLine("Substring not found.");

      Console.Write("Enter substring to replace: ");
      string toReplace = Console.ReadLine();
      Console.Write("Enter replacement: ");
      string replacement = Console.ReadLine();
      string replaced = concat.Replace(toReplace, replacement);
      Console.WriteLine($"After replacement: {replaced}");
    }
  }
}
