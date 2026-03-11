using System;
using System.Security.Cryptography;
namespace ListFahad
{
  public class customer
  {
    public string name;
    public int age;
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      // List<int> arr = new List<int>();
      List<customer> brr = new List<customer>();
      customer c1 = new customer { name = "fahad", age = 1113 };
      customer c2 = new customer { name = "asfahasdsd", age = 113 };
      customer c3 = new customer { name = "ddfdfsdahad", age = 143 };
      // arr.Add(10);
      // arr.Add(30);
      // arr.Add(20);
      // arr.Sort((a, b) => b.CompareTo(a));
      brr.Add(c1);
      brr.Add(c2);
      brr.Add(c3);
      brr.Sort((a, b) => a.name.CompareTo(b.name));
      foreach (customer x in brr)
      {
        System.Console.WriteLine(x.name);
      }

    }
  }

}