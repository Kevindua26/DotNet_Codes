using System;

namespace DotNet
{
  // Q29: Demonstrate Destructor (finalizer)
  public class Q29_Destructor
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q29 Destructor/Finalizer Demo --");
      CreateAndRelease();
      // Force garbage collection to try and run finalizers (non-deterministic)
      GC.Collect();
      GC.WaitForPendingFinalizers();
      Console.WriteLine("GC completed. If finalizer ran you should have seen a message above.");
    }

    private static void CreateAndRelease()
    {
      var obj = new Demo();
      obj = null; // Eligible for GC
    }
  }

  public class Demo
  {
    ~Demo()
    {
      Console.WriteLine("Demo finalizer executed");
    }
  }
}
