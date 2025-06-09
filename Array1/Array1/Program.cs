using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("You have entered: {0}", input);
            Console.WriteLine($"What you said is: {input}");
            Console.ReadKey();


        }
    }
}
