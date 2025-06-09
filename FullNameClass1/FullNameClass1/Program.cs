using System; 
namespace FullName
{

    public class Names
    {
        public string firstName = "FirstName";
        public string LastName = "LastName";

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {firstName} {LastName}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Names Raski = new Names();
            Raski.firstName = "Raski";
            Raski.LastName = "Abid"; 
           
            Raski.Introduce();

            Names Nabil = new Names();

            Nabil.Introduce(); 
            
        }
    }
}