using System;

namespace DotNet
{
  // Q22: Demonstrate method overloading and method overriding
  public class Q22_MethodOverloadOverride
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q22 Method Overloading and Overriding Demo --");

      // Overloading demo
      var util = new Calculator();
      Console.WriteLine(util.Add(2, 3));          // int, int
      Console.WriteLine(util.Add(2.5, 3.7));      // double, double
      Console.WriteLine(util.Add(1, 2, 3));       // 3 args

      // Overriding demo
      AnimalSimple a = new AnimalSimple();
      AnimalSimple d = new DogSimple();
      a.Speak(); // base
      d.Speak(); // overridden
    }
  }

  // Method overloading example
  public class Calculator
  {
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
  }

  // Method overriding example
  public class AnimalSimple
  {
    public virtual void Speak()
    {
      Console.WriteLine("Animal speaks");
    }
  }

  public class DogSimple : AnimalSimple
  {
    public override void Speak()
    {
      Console.WriteLine("Dog barks");
    }
  }
}
