//Imagine you are a developer and get a job in which you need to create a program for a teacher. He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
//So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores, the program should write onto the console what the average score is.
//The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
//Test your program thoroughly.

using System; 
namespace Loop
{
    public class Program
    {
        static int sum = 0; 
        static double average = 0;
        static int number = 0; 
        static int numCount = 0; 
        public static void Main(string[] args)
        {   

            while(true)
            {
                Console.WriteLine("Enter obtained mark of student. Enter \"-1\" to calculate average");
                bool isNumber = int.TryParse(Console.ReadLine(), out number);

                if (number == -1) break; 


                if (isNumber)
                {   
                    if(number >= 0 && number <= 100)
                    {
                        sum += number;
                        numCount++;
                        Console.WriteLine("Number of entries: " +numCount);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 0 and 100");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid Input, try again"); 
                }
            }

            average = (double)sum / numCount; 
            Console.WriteLine($"Average number is {average}");
            

        }
    }
}