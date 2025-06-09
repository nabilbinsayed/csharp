using System; 

namespace MethodTest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine($"{num1}/{num2} = {Divide(num1, num2)}");

        }

        public static double Divide(int a, int b)
        {
            return (double)a / b; 
        }

        
    }
}