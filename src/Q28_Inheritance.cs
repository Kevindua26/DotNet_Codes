using System;

namespace DotNet
{
  // Q28: Show inheritance (Multilevel and Hierarchical)
  public class Q28_Inheritance
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q28 Inheritance Demo --");
      // Hierarchical: Mammal and Bird both derive from Animal
      AnimalBase generic = new AnimalBase();
      Mammal mammal = new Mammal();
      Bird bird = new Bird();
      generic.Eat(); mammal.Eat(); bird.Eat();

      // Multilevel: Dog derives from Mammal which derives from Animal
      DogMulti dog = new DogMulti();
      dog.Eat();
      dog.Bark();
    }
  }

  public class AnimalBase
  {
    public void Eat() => Console.WriteLine("Animal eats");
  }

  public class Mammal : AnimalBase
  {
    public void Nurse() => Console.WriteLine("Mammal nurses young");
  }

  public class Bird : AnimalBase
  {
    public void Fly() => Console.WriteLine("Bird flies");
  }

  public class DogMulti : Mammal
  {
    public void Bark() => Console.WriteLine("Dog barks");
  }
}
