using System;
using System.Collections.Generic;

namespace DotNet
{
  // Q37: Vehicle base class and Truck derived class with statistics
  public class Q37_VehicleTruck
  {
    public static void Main(string[] args)
    {
      var list = new List<Vehicle>();
      list.Add(new Vehicle("Toyota", "Camry", 2020));
      list.Add(new Truck("Volvo", "FH", 2022, 18000));
      list.Add(new Truck("Ford", "F150", 2019, 3000));

      foreach (var v in list) v.DisplayInfo();
      Vehicle.ShowVehicleStatistics();
    }
  }

  public class Vehicle
  {
    public string Make { get; }
    public string Model { get; }
    public int Year { get; }
    public static int TotalVehicles { get; private set; } = 0;

    public Vehicle(string make, string model, int year)
    {
      Make = make; Model = model; Year = year;
      TotalVehicles++;
    }

    ~Vehicle()
    {
      TotalVehicles--;
    }

    public virtual void DisplayInfo()
    {
      Console.WriteLine($"{Year} {Make} {Model}");
    }

    public static void ShowVehicleStatistics()
    {
      Console.WriteLine($"Total vehicles: {TotalVehicles}");
      Console.WriteLine($"(Total trucks tracked via Truck.TotalTrucks: {Truck.TotalTrucks})");
    }
  }

  public class Truck : Vehicle
  {
    public double PayloadCapacity { get; }
    public static int TotalTrucks { get; private set; } = 0;

    public Truck(string make, string model, int year, double payload) : base(make, model, year)
    {
      PayloadCapacity = payload;
      TotalTrucks++;
    }

    ~Truck()
    {
      TotalTrucks--;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"PayloadCapacity: {PayloadCapacity} kg");
    }
  }
}
