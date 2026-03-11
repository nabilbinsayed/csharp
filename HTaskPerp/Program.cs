using System;
using System.Collections.Generic;

abstract class Animal
{
  public int ID { get; set; }
  public abstract string Type { get; }
  public abstract string GetInfo();
}

class Cow : Animal
{
  public float MilkPerDay { get; set; }
  public override string Type { get { return "Cow"; } }
  public override string GetInfo() { return "Milk/day: " + MilkPerDay; }
}

class Chicken : Animal
{
  public int EggsPerDay { get; set; }
  public override string Type { get { return "Chicken"; } }
  public override string GetInfo() { return "Eggs/day: " + EggsPerDay; }
}

class Sheep : Animal
{
  public float WoolPerMonth { get; set; }
  public override string Type { get { return "Sheep"; } }
  public override string GetInfo() { return "Wool/month: " + WoolPerMonth; }
}

class Farm
{
  private List<Animal> animals = new List<Animal>();
  private int nextId = 1;
  private const int MaxAnimals = 100;

  public void AddCow()
  {
    if (animals.Count >= MaxAnimals)
    {
      Console.WriteLine("Farm is full.");
      return;
    }
    float milk;
    while (true)
    {
      Console.Write("Enter milk per day (float): ");
      string input = Console.ReadLine();
      if (float.TryParse(input, out milk)) break;
      else Console.WriteLine("Invalid input.");
    }
    Cow cow = new Cow();
    cow.ID = nextId++;
    cow.MilkPerDay = milk;
    animals.Add(cow);
    Console.WriteLine("Cow added.");
  }

  public void AddChicken()
  {
    if (animals.Count >= MaxAnimals)
    {
      Console.WriteLine("Farm is full.");
      return;
    }
    int eggs;
    while (true)
    {
      Console.Write("Enter eggs per day (int): ");
      string input = Console.ReadLine();
      if (int.TryParse(input, out eggs)) break;
      else Console.WriteLine("Invalid input.");
    }
    Chicken chicken = new Chicken();
    chicken.ID = nextId++;
    chicken.EggsPerDay = eggs;
    animals.Add(chicken);
    Console.WriteLine("Chicken added.");
  }

  public void AddSheep()
  {
    if (animals.Count >= MaxAnimals)
    {
      Console.WriteLine("Farm is full.");
      return;
    }
    float wool;
    while (true)
    {
      Console.Write("Enter wool per month (float): ");
      string input = Console.ReadLine();
      if (float.TryParse(input, out wool)) break;
      else Console.WriteLine("Invalid input.");
    }
    Sheep sheep = new Sheep();
    sheep.ID = nextId++;
    sheep.WoolPerMonth = wool;
    animals.Add(sheep);
    Console.WriteLine("Sheep added.");
  }

  public void ListAnimals()
  {
    if (animals.Count == 0)
    {
      Console.WriteLine("No animals in the farm.");
      return;
    }
    Console.WriteLine("\n| ID | Type    | Info            |");
    Console.WriteLine("|----|---------|-----------------|");
    for (int i = 0; i < animals.Count; i++)
    {
      Animal a = animals[i];
      Console.WriteLine($"| {a.ID} | {a.Type} | {a.GetInfo()} |");
    }
  }

  public void SearchAnimal()
  {
    Console.Write("Enter ID to search: ");
    string input = Console.ReadLine();
    int id;
    if (!int.TryParse(input, out id))
    {
      Console.WriteLine("Invalid input.");
      return;
    }
    Animal found = null;
    for (int i = 0; i < animals.Count; i++)
    {
      if (animals[i].ID == id)
      {
        found = animals[i];
        break;
      }
    }
    if (found != null)
    {
      Console.WriteLine("Found:");
      Console.WriteLine("ID: " + found.ID);
      Console.WriteLine("Type: " + found.Type);
      Console.WriteLine(found.GetInfo());
    }
    else
    {
      Console.WriteLine("Animal not found.");
    }
  }

  public void DeleteAnimal()
  {
    Console.Write("Enter ID to delete: ");
    string input = Console.ReadLine();
    int id;
    if (!int.TryParse(input, out id))
    {
      Console.WriteLine("Invalid input.");
      return;
    }
    for (int i = 0; i < animals.Count; i++)
    {
      if (animals[i].ID == id)
      {
        animals.RemoveAt(i);
        Console.WriteLine("Animal deleted.");
        return;
      }
    }
    Console.WriteLine("Animal not found.");
  }

  public void ShowStats()
  {
    int cowCount = 0, chickenCount = 0, sheepCount = 0;
    float totalMilk = 0f, totalWool = 0f;
    int totalEggs = 0;
    foreach (var a in animals)
    {
      switch (a)
      {
        case Cow cow:
          cowCount++;
          totalMilk += cow.MilkPerDay;
          break;
        case Chicken chicken:
          chickenCount++;
          totalEggs += chicken.EggsPerDay;
          break;
        case Sheep sheep:
          sheepCount++;
          totalWool += sheep.WoolPerMonth;
          break;
      }
    }
    int total = cowCount + chickenCount + sheepCount;
    Console.WriteLine($"\nTotal Animals: {total}");
    Console.WriteLine($"Cows: {cowCount}");
    Console.WriteLine($"Chickens: {chickenCount}");
    Console.WriteLine($"Sheep: {sheepCount}");
    Console.WriteLine($"\nTotal Milk/Day: {totalMilk} L");
    Console.WriteLine($"Total Eggs/Day: {totalEggs}");
    Console.WriteLine($"Total Wool/Month: {totalWool} kg");

    if (total > 0)
    {
      double cowPct = Math.Round(cowCount * 100.0 / total, 2);
      double chickenPct = Math.Round(chickenCount * 100.0 / total, 2);
      double sheepPct = Math.Round(sheepCount * 100.0 / total, 2);
      Console.WriteLine($"\nCows: {cowPct}%");
      Console.WriteLine($"Chickens: {chickenPct}%");
      Console.WriteLine($"Sheep: {sheepPct}%");
    }
  }
}

class Program
{
  static void Main()
  {
    Farm farm = new Farm();
    string choice;
    while (true)
    {
      Console.WriteLine("\n---------------------");
      Console.WriteLine("1. Add Cow");
      Console.WriteLine("2. Add Chicken");
      Console.WriteLine("3. Add Sheep");
      Console.WriteLine("4. List Animals");
      Console.WriteLine("5. Search Animal by ID");
      Console.WriteLine("6. Delete Animal by ID");
      Console.WriteLine("7. Get Statistics");
      Console.WriteLine("8. Exit");
      Console.Write("Enter choice (1–8): ");
      choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          farm.AddCow(); break;
        case "2":
          farm.AddChicken(); break;
        case "3":
          farm.AddSheep(); break;
        case "4":
          farm.ListAnimals(); break;
        case "5":
          farm.SearchAnimal(); break;
        case "6":
          farm.DeleteAnimal(); break;
        case "7":
          farm.ShowStats(); break;
        case "8": break;
        default:
          Console.WriteLine("Invalid option."); break;
      }
      if (choice == "8") break;
    }
  }
}
