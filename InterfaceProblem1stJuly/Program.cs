using System;
namespace InterfaceDemo
{

  interface Employee
  {
    public void CheckSecret();

  }

  class Leader : Employee
  {
    public void CheckSecret()
    {
      System.Console.WriteLine("I know the secrets");

    }
  }
  class Normal : Employee
  {
    public void CheckSecret()
    {
      System.Console.WriteLine("I DO NOT know the secrets");

    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Leader Boss1 = new Leader();
      Normal NormalGuy = new Normal();
      Boss1.CheckSecret();
      NormalGuy.CheckSecret();
    }
  }
}