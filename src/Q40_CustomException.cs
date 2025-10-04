using System;

namespace DotNet
{
  // Q40: Custom exception InvalidAgeException
  public class Q40_CustomException
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter age: ");
      if (!int.TryParse(Console.ReadLine(), out int age)) { Console.WriteLine("Invalid input"); return; }
      try
      {
        if (age < 0) throw new InvalidAgeException(age);
        Console.WriteLine($"Accepted age: {age}");
      }
      catch (InvalidAgeException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }

  public class InvalidAgeException : Exception
  {
    public int Age { get; }
    public InvalidAgeException(int age) : base($"Invalid age: {age}") { Age = age; }
  }
}
