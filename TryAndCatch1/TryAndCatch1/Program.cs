using System; 
namespace TryCatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int inputNum = int.Parse(input);
                Console.WriteLine(inputNum);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null argument exception");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception");
            }
            finally
            {
                Console.WriteLine("\"Finally\" block executed");
            }
        }
    }
}