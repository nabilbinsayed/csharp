using System;
namespace JaggedArray
{
  public class Program
  {
    // jagged array = array within an array
    public static void Main(string[] args)
    {
      int[][] jagArr1 = new int[3][]; // 3 arrays within the parent array

      jagArr1[0] = new int[5] { 1, 2, 3, 4, 5 };
      jagArr1[1] = new int[3] { 2, 4, 6 };
      jagArr1[2] = new int[2] { 1, 3 };

      int[][] jagArr2 = new int[][]
      {
        new int[] {2, 3, 6},
        new int[] {1, 2}
      };

      System.Console.WriteLine($"the value in the middle of the second entry in jagArr1 is {jagArr1[1][1]}");
      System.Console.WriteLine($"length of jagged array 2: {jagArr2.Length}");
      System.Console.WriteLine($"length of jagged array 2[0]: {jagArr2[0].Length}");

      System.Console.WriteLine("\njagged array 2: ");


      for (int i = 0; i < jagArr2.Length; i++)
      {
        for (int j = 0; j < jagArr2[i].Length; j++)
        {
          Console.Write($"{jagArr2[i][j]} ");
        }
        System.Console.WriteLine();
      }

      // foreach (int x in jagArr1[0])
      // {
      //   jagArr1[0][x] = 2*x; 
      //   System.Console.Write(jagArr1[0][x] + " ");
      // }
      // System.Console.WriteLine();
      // foreach (int x in jagArr1[1])
      // {
      //   jagArr1[0][x] = 3 * x - 1;
      //   System.Console.Write(jagArr1[1][x] + " ");
      // }
      // System.Console.WriteLine();

      // foreach (int x in jagArr1[2])
      // {
      //   jagArr1[0][x] = x;
      //   System.Console.Write(jagArr1[2][x] + " ");
      // }






    }




  }
}