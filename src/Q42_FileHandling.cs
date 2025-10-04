using System;
using System.IO;

namespace DotNet
{
  // Q42: Simple file handling: create, write, read
  public class Q42_FileHandling
  {
    public static void Main(string[] args)
    {
      string path = Path.Combine(Environment.CurrentDirectory, "demo.txt");
      File.WriteAllText(path, "Hello from Q42 FileHandling!\nThis is a test file.");
      Console.WriteLine($"Wrote file: {path}");
      Console.WriteLine("Content:");
      Console.WriteLine(File.ReadAllText(path));
    }
  }
}
