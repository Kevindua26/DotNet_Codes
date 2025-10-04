using System;

namespace DotNet
{
  // Q21: Demonstrate different types of constructors
  public class Q21_Constructors
  {
    private int x;

    // Static constructor
    static Q21_Constructors()
    {
      Console.WriteLine("Static constructor: runs once before any instance is created.");
    }

    // Default constructor
    public Q21_Constructors()
    {
      x = 0;
      Console.WriteLine("Default constructor: x = 0");
    }

    // Parameterized constructor
    public Q21_Constructors(int value)
    {
      x = value;
      Console.WriteLine($"Parameterized constructor: x = {x}");
    }

    // Copy constructor (simulated)
    public Q21_Constructors(Q21_Constructors other)
    {
      x = other.x;
      Console.WriteLine($"Copy constructor: x copied = {x}");
    }

    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q21 Constructors Demo --");
      var a = new Q21_Constructors();
      var b = new Q21_Constructors(42);
      var c = new Q21_Constructors(b);
    }
  }
}
