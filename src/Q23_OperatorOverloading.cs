using System;

namespace DotNet
{
  // Q23: Demonstrate operator overloading (Complex number addition, equality)
  public class Q23_OperatorOverloading
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q23 Operator Overloading Demo --");
      var c1 = new Complex(2, 3);
      var c2 = new Complex(1, -4);
      var sum = c1 + c2;
      Console.WriteLine($"{c1} + {c2} = {sum}");
      Console.WriteLine($"c1 == c2? {(c1 == c2)}");
      var c3 = new Complex(3, -1);
      Console.WriteLine($"sum == c3? {(sum == c3)}");
    }
  }

  public struct Complex
  {
    public double Real { get; }
    public double Imag { get; }

    public Complex(double real, double imag)
    {
      Real = real;
      Imag = imag;
    }

    public static Complex operator +(Complex a, Complex b)
    {
      return new Complex(a.Real + b.Real, a.Imag + b.Imag);
    }

    public static bool operator ==(Complex a, Complex b)
    {
      return a.Real == b.Real && a.Imag == b.Imag;
    }

    public static bool operator !=(Complex a, Complex b) => !(a == b);

    public override bool Equals(object? obj)
    {
      if (obj is Complex other) return this == other;
      return false;
    }

    public override int GetHashCode() => HashCode.Combine(Real, Imag);

    public override string ToString() => $"({Real} {(Imag < 0 ? "-" : "+")} {Math.Abs(Imag)}i)";
  }
}
