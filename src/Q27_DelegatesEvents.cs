using System;

namespace DotNet
{
  // Q27: Demonstrate Delegates and Events
  public class Q27_DelegatesEvents
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q27 Delegates and Events Demo --");

      // Delegate example
      Func<int, int, int> op = (a, b) => a + b;
      Console.WriteLine($"Delegate add: 5 + 7 = {op(5, 7)}");

      // Event example
      var publisher = new Counter();
      var subscriber = new Subscriber();
      publisher.ThresholdReached += subscriber.HandleThreshold;
      for (int i = 0; i < 7; i++) publisher.Increment();
    }
  }

  // Simple publisher with an event
  public class Counter
  {
    private int count = 0;
    public event EventHandler<int>? ThresholdReached;
    public void Increment()
    {
      count++;
      Console.WriteLine($"Counter: {count}");
      if (count >= 5) ThresholdReached?.Invoke(this, count);
    }
  }

  public class Subscriber
  {
    public void HandleThreshold(object? sender, int value)
    {
      Console.WriteLine($"Subscriber received threshold event: count = {value}");
    }
  }
}
