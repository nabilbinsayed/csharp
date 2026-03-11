using System;

namespace MaxMinParam
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Minimum of 1, 2, 5, 5, -2 is: {FindMin(1, 2, 5, 5, -2)}"); 
      Console.WriteLine($"Maximum of 1, 2, 5, 5, -2 is: {FindMax(1, 2, 5, 5, -2)}"); 
    }
    static int FindMin(params int[] numbers)
    {
      int min = int.MaxValue;
      foreach (int x in numbers)
      {
        if (x < min)
        {
          min = x;
        }
      }
      return min; 
    }

    static int FindMax(params int[] numbers)
    {
      int max = int.MinValue;
      foreach (int x in numbers)
      {
        if (x > max)
        {
          max = x;
        }
      }
      return max;
    }
  }
}