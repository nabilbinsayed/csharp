using System; 
namespace TryParse1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numParsed;

            Console.WriteLine("Enter a number: ");

            string numString = Console.ReadLine();



            bool isParsed = int.TryParse(numString, out numParsed); 

            if (isParsed)
            {
                Console.WriteLine($"Parsed successfully, number is: {numParsed}");
            }
            else
            {
                Console.WriteLine($"Parsing failed. Something wrong with the input: {numString}");
            }
        }
    }
}