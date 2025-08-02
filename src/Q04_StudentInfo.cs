// Q4: Write an application that receives the following information from a set of students:
// Student Id, Student Name, Course Name, Date of Birth
// The application should also display the information of all the students once the data is entered.
// Implement this using an Array of Structures.
using System;

namespace DotNet
{
  public class Q4_StudentInfo
  {
    struct Student
    {
      public int Id;
      public string Name;
      public string Course;
      public DateTime DOB;
    }

    public static void Main(string[] args){
      Console.Write("Enter number of students: ");
      int n = int.Parse(Console.ReadLine());
      Student[] students = new Student[n];

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"\nEnter details for student #{i + 1}:");
        Console.Write("Student Id: ");
        students[i].Id = int.Parse(Console.ReadLine());
        Console.Write("Student Name: ");
        students[i].Name = Console.ReadLine();
        Console.Write("Course Name: ");
        students[i].Course = Console.ReadLine();
        Console.Write("Date of Birth (yyyy-mm-dd): ");
        students[i].DOB = DateTime.Parse(Console.ReadLine());
      }

      Console.WriteLine("\nStudent Information:");
      foreach (var s in students)
      {
        Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Course: {s.Course}, DOB: {s.DOB:yyyy-MM-dd}");
      }
    }
  }
}
