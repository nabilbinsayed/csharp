//Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).
//As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
//User If statements and User Input and Methods to solve the challenge.

using System; 
namespace Login
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string username, password; 

            Console.WriteLine("Enter a username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter a password: ");
            password = Console.ReadLine();

            Console.WriteLine("Registration successful");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Enter your username to login: ");
            string loginUsername = Console.ReadLine();
            Console.WriteLine("Enter your password to login: ");
            string loginPassword = Console.ReadLine();

            if(loginUsername.Equals(username) && loginPassword.Equals(password))
            {
                Console.WriteLine("Login successful");  
            }
            else
            {
                Console.WriteLine("Login failed. Incorrect username or password.");
            }


        }
    }
}