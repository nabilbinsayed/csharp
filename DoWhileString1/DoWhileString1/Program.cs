using System; 
namespace DoWhileString
{
    public class Program
    {
        static string wholeText = ""; 
        static int stringLength = 0;

    public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter a name: ");
                string friendName = Console.ReadLine();
                wholeText = wholeText + " " + friendName;

            } while (wholeText.Length <= 20);

            Console.WriteLine($"Thank you {wholeText}");
            Console.WriteLine(wholeText.Length);


        }





    }
}