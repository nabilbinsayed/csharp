namespace MemberFinalizerDestructor
{


    public class Program
    {
        public static void Main(string[] args)
        {
            Members Alice = new Members("Alice", "Software Engineer", 70000, 30);
            Alice.Introducing(false); // it calls a public method, which has a private method within, only then can I access the private info
                                      //Alice.SharingPrivateInfo(); // this will cause an error because SharingPrivateInfo is private and cannot be accessed directly
            Members Bob = new Members("Bob", "Data Scientist", 80000, 28);
            Bob.Introducing(true);

            Console.ReadKey(); // wait for user input before closing the console window
        }
    }
}