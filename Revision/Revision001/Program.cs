using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
namespace Revision
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] ages = new int[] { 1, 2, 3 };
      foreach (var x in ages)
      {
        System.Console.WriteLine(x);
      }
      // int[,] MultiDim = new int[,]
      // {
      //   {1, 2, 3},
      //   {3, 4, 5},
      //   {6, 7, 8}
      // };

      // for (int i = 0; i < MultiDim.GetLength(0); i++)
      // {
      //   for (int j = 0; j < MultiDim.GetLength(1); j++)
      //   {
      //     Console.Write(MultiDim[i, j] + " ");
      //   }
      //   System.Console.WriteLine();
      // }



      System.Console.WriteLine();
      double sumAges, averageAge;
      Summation(ages, out sumAges, out averageAge);

      System.Console.WriteLine($"Sum of ages is {sumAges}");
      System.Console.WriteLine($"Average of ages is {averageAge}");



    }



    public static void Summation(int[] numbers, out double total, out double average)
    {
      total = 0;
      average = 0;
      int count = 0;
      foreach (int x in numbers)
      {
        total += x;
        count++;
      }
      average = total / count;
    }
  }
}