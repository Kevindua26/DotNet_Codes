// Q7: Write a Program in C# to demonstrate Command line arguments Processing.
using System;

namespace DotNet
{
  public class Q7_CommandLineArgs
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Command line arguments:");
      foreach (string arg in args)
      {
        Console.WriteLine(arg);
      }
    }
  }
}
