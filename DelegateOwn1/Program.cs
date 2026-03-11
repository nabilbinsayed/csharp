using System;
namespace DelegateDemoOwn
{

  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int Age)
    {
      this.Age = Age;
      Name = name;
    }
  }
  public class Program
  {

    public delegate bool FilterAgeDelegate(Person p);

    public static void Main(string[] args)
    {
      Person p1 = new Person("fahad", 10);
      Person p2 = new Person("rafsan", 20);
      Person p3 = new Person("atif", 17);

      List<Person> guys = new List<Person>() { p1, p2, p3 };

      DisplayPeople("\nKids\n", guys, IsMinor); 
      DisplayPeople("\nAdults\n", guys, IsAdult); 
      DisplayPeople("\nSeniors\n", guys, IsSenior); 

    }

    static void DisplayPeople(string title, List<Person> guys, FilterAgeDelegate filter)
    {
      System.Console.WriteLine(title);

      foreach (Person p in guys)
      {
        if (filter(p))
        {
          System.Console.WriteLine($"Name is {p.Name}, age is {p.Age}");
        }
      }
    }

    static bool IsMinor(Person p)
    {
      return p.Age < 18; 
    }
    static bool IsAdult(Person p)
    {
      return p.Age >= 18; 
    }
    static bool IsSenior(Person p)
    {
      return p.Age >= 65; 
    }


  }
}