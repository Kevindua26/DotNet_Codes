using System;

namespace DotNet
{
  // Q31: Use of properties and indexers
  public class Q31_PropertiesIndexers
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("-- Q31 Properties & Indexers Demo --");
      var team = new Team("Developers");
      team[0] = "Alice";
      team[1] = "Bob";
      Console.WriteLine($"Team: {team.Name}");
      for (int i = 0; i < team.Count; i++) Console.WriteLine(team[i]);
    }
  }

  public class Team
  {
    private string[] members = new string[10];
    public string Name { get; set; }
    public int Count { get; private set; } = 0;
    public Team(string name) { Name = name; }

    public string this[int index]
    {
      get => members[index];
      set
      {
        members[index] = value;
        if (index >= Count) Count = index + 1;
      }
    }
  }
}
