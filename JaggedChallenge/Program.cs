using System;
namespace Jagged
{
  class Program
  {
    public static void Main(string[] args)
    {
      string[] mechanics = new string[] { "Bodi", "Alom" };
      string[] engineers = new string[] { "Abdul", "Motin", "Hafez" };
      string[] doctors = new string[] { "Baker" };

      string[][] team = new string[][] {
        mechanics,
        engineers,
        doctors
      };

      System.Console.WriteLine(team.Length);
      System.Console.WriteLine(team[1].Length);

      for (int i = 0; i < team.Length; i++)
      {
        for (int j = 0; j < team[i].Length; j++)
        {
          Console.Write(team[i][j] + " ");
        }
        System.Console.WriteLine();
      }


    }
  }
}