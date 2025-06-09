

using System;

namespace LabClassIntro
{
  public class UserInput
  {
    public static void Main(string[] args)
    {
      double num1, num2, result;



      while (1)
      {
        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");

        num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter your choice: (+, -, *, %, ^). Type E to end: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
          case "+":
            result = num1 + num2;
            Console.WriteLine("Result is: " + result);
            break;
          case "-":
            result = num1 - num2;
            Console.WriteLine("Result is: " + result);
            break;
          case "*":
            result = num1 * num2;
            Console.WriteLine("Result is: " + result);
            break;
          case "%":
            result = num1 % num2;
            Console.WriteLine("Result is: " + result);
            break;
          case "^":
            result = Math.Pow(num1, num2);
            Console.WriteLine("Result is: " + result);
            break;
          case "E":
            break;


          default:
            Console.WriteLine("Invalid Input");
            break;



        }
      }




    }

  }
}
