using System;
using Class1;
namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human Saiban = new Human();
            Saiban.firstName = "Al";
            Saiban.Introduce();
            Human Raski = new Human();
            Raski.firstName = "Raski";
            Raski.Introduce();
            Human Abid = new Human();
            Abid.Introduce();

        }
    }
}