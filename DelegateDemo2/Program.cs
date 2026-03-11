using System;
namespace DelegateDemo
{
  public class Operation
  {
    char sign;

    public Operation(char sign)
    {
      this.sign = sign;
    }
  }
  public class Program
  {
    public delegate void OperationFilter(Operation op);
    public static void Main(string[] args)
    {

    }

    public static void DisplayOutput(int x, int y, Operation op, OperationFilter filter)
    {
      if
    }


  }
}
