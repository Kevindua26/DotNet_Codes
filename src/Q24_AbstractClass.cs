using System;

namespace DotNet
{
  // Q24: Demonstrate abstract class and abstract methods
  public class Q24_AbstractClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q24 Abstract Class Demo --");
      Shape s1 = new Circle(3);
      Shape s2 = new Rectangle(4, 5);
      Console.WriteLine($"Circle area: {s1.Area():F2}");
      Console.WriteLine($"Rectangle area: {s2.Area():F2}");
    }
  }

  public abstract class Shape
  {
    public abstract double Area();
  }

  public class Circle : Shape
  {
    private double r;
    public Circle(double radius) { r = radius; }
    public override double Area() => Math.PI * r * r;
  }

  public class Rectangle : Shape
  {
    private double w, h;
    public Rectangle(double width, double height) { w = width; h = height; }
    public override double Area() => w * h;
  }
}
