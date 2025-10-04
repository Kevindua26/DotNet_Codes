using System;

namespace DotNet
{
  // Q30: Demonstrate arrays of interface types
  public class Q30_InterfaceArray
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q30 Arrays of Interface Types Demo --");
      IWorker[] workers = new IWorker[] {
                new Developer("Eve"),
                new Tester("Mallory"),
                new Developer("Trent")
            };

      foreach (var w in workers)
      {
        w.Work();
      }
    }
  }

  public interface IWorker
  {
    void Work();
  }

  public class Developer : IWorker
  {
    private string name;
    public Developer(string name) { this.name = name; }
    public void Work() => Console.WriteLine($"Developer {name} is coding.");
  }

  public class Tester : IWorker
  {
    private string name;
    public Tester(string name) { this.name = name; }
    public void Work() => Console.WriteLine($"Tester {name} is testing.");
  }
}
