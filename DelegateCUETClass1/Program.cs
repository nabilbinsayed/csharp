using System;
namespace DelegateDemo
{
  public class Program
  {
    public delegate void Calculate(int x, int y);

    public static void Main(string[] args)
    {
      Calculate calc1 = new Calculate(Add);

      calc1(1, 3);
      
    }

    public static void Multiply(int x, int y)
    {
      System.Console.WriteLine(x * y);
    }
    public static void Add(int x, int y)
    {
      System.Console.WriteLine(x + y);
    }





  }
}