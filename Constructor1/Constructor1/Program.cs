using System;
namespace Constructor
{

    public class Human
    {
        public string firstName; 
        public string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Introduce ()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Human Raski = new Human("Raski", "Abid"); 

            Raski.Introduce();

        }
    }
}