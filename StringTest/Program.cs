using System;
namespace String
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string firstName = "bodi ";
      string lastName = "alom";
      string fullName;
      fullName = string.Concat(firstName, lastName);
      System.Console.WriteLine(fullName);

      double num = Math.Pow(2, 3); 
      System.Console.WriteLine(num); 
    }
  }
}