using System;
namespace Lab
{
  class Program
  {
    public static void Main(string[] args)
    {
      int x, y;
      System.Console.Write("Enter x: ");
      x = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("Enter y: ");
      y = Convert.ToInt32(Console.ReadLine());

      if (y % 2 == 0)
      {
        double ans = (double)x / y;
        System.Console.WriteLine($"{x}/{y} = {ans}");
      }
      else
      {
        throw new Exception("Can't divide by odd number"); 
      }
    }
  }
}