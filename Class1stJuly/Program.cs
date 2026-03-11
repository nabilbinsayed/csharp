using System;

// interface and abstract class
namespace classProblem
{
  public abstract class Employee
  {
    string companyName = "ABC Pharma";

    public abstract void KnowSecret();
  }

  public class Leader : Employee
  {
    public override void KnowSecret()
    {
      System.Console.WriteLine("I know the secrets");
    }
  }
  public class Worker : Employee
  {
    public override void KnowSecret()
    {
      System.Console.WriteLine("I DON'T know the secrets");
    }
  }



  public class Program
  {
    public static void Main(string[] args)
    {
      Leader Boss1 = new Leader();
      Worker NormalGuy = new Worker();
      Boss1.KnowSecret();
      NormalGuy.KnowSecret();
    }
  }
}