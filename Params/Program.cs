using System;

namespace Params
{
  class Program
  {
    static void Main(string[] args)
    {
      int total;
      total = Summation(1, 2, 3);
      PrintOut(1, 2, 3); 
      System.Console.WriteLine($"Sum of the numbers is {total}");
    }

    static int Summation(params int[] numbers)
    {
      int sum = 0;
      foreach (int x in numbers)
      {
        sum += x;
      }
      return sum;
    }

    static void PrintOut(params int[] numbers)
    {
      foreach (int x in numbers)
      {
        Console.Write(x + " "); 
      }
    }
  }
}