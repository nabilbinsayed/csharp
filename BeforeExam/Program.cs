using System;
namespace HTask
{

  public class Animal
  {
    int ID = 0;
    const int maxAnimals = 100; 

    List<Animal> animals = new List<Animal>(); 
    public void SearchID(int ID)
    {
      
    }
    public void DeleteID(int ID)
    {

    }
    public Animal()
    {
      ID++;
    }
  }

  public class Cow : Animal
  {
    float milkPerDay;
    int numCow = 0;
    public Cow() : base()
    {
      numCow++;
    }
  }
  public class Chicken : Animal
  {
    int eggsPerDay;
    int numChicken = 0;
    public Chicken() : base()
    {
      numChicken++;
    }
  }
  public class Sheep : Animal
  {
    float woolPerMonth;
    int numSheep = 0;
    public Sheep() : base()
    {
      numSheep++;
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {

    }
  }
}