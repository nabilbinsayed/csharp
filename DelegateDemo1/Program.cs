using System;
namespace DelegateDemo
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<string> names = new List<string>() { "fahad", "abdul", "bodi" };

      System.Console.WriteLine("----------Before----------");
      foreach (var x in names)
      {
        Console.Write(x + " ");
      }


      names.RemoveAll(Filter); // expects a predicate
      // names.Sort((a, b) => a.CompareTo(b));


      System.Console.WriteLine("\n----------After----------");
      foreach (var x in names)
      {
        Console.Write(x + " ");
      }



    }

    static bool Filter(string s)
    {
      return s.Contains("i");
    }

    



  }
}