using System; 
namespace TryCatch2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter a divisor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());



            try
            {
                double divident = (double)num1 / num2;

                Console.WriteLine($"{num1}/{num2} = {divident}");
                Console.Read();

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can't divide by 0");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
                Console.Read(); 
            }
            catch(FormatException)
            {
                Console.WriteLine("Format exception");
            }
            catch(Exception)
            {
                Console.WriteLine("General Exception");
            }
            finally
            {
                Console.WriteLine("Program closed");
                Console.Read();
            }

        }
    }
}
