using System;
namespace ArrayAsParameter
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] marks = new int[] { 90, 87, 84 };

      double average = GetAverage(marks);
      System.Console.WriteLine(average);

    }

    static double GetAverage(int[] gradeArray)
    {
      int len = gradeArray.Length;
      int sum = 0;
      foreach (int x in gradeArray)
      {
        sum += x;
      }

      double average = (double)sum / len;
      return average;
    }


  }
}