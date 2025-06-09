//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace TestCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            System.Console.Write("Enter a character to search: ");
            char inputChar = Convert.ToChar(Console.ReadLine()); 
            System.Console.WriteLine(inputChar);
            int index = input.IndexOf(inputChar);
            Console.WriteLine($"Index of {inputChar} is {index+1}");
        }
    }
}