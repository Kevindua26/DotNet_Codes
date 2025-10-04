using System;

namespace DotNet
{
  // Q25: Build a class which implements an existing interface (IComparable)
  public class Q25_InterfaceImplementation
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q25 Interface Implementation Demo --");
      var people = new Person[] {
                new Person("Alice", 30),
                new Person("Bob", 25),
                new Person("Carol", 28)
            };
      Array.Sort(people); // Uses IComparable
      foreach (var p in people) Console.WriteLine(p);
    }
  }

  public class Person : IComparable
  {
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age) { Name = name; Age = age; }

    // Implement IComparable to sort by Age
    public int CompareTo(object? obj)
    {
      if (obj is Person other) return Age.CompareTo(other.Age);
      throw new ArgumentException("Object is not a Person");
    }

    public override string ToString() => $"{Name} ({Age})";
  }
}
