using System;
using System.Threading;

namespace DotNet
{
  // Q26: Implement threading concepts
  public class Q26_Threading
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q26 Threading Demo --");
      Thread t1 = new Thread(() => PrintNumbers("T1", 1, 5));
      Thread t2 = new Thread(() => PrintNumbers("T2", 100, 5));
      t1.Start();
      t2.Start();
      t1.Join();
      t2.Join();
      Console.WriteLine("Both threads finished.");
    }

    private static void PrintNumbers(string name, int start, int count)
    {
      for (int i = 0; i < count; i++)
      {
        Console.WriteLine($"{name}: {start + i}");
        Thread.Sleep(100);
      }
    }
  }
}
