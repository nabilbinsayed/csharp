namespace DataTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any input: ");
            string input = Console.ReadLine();

            Console.WriteLine("Specify input data type: \nPress 1 for String\nPress 2 for integer\nPress 3 for Boolean");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bool isString = false;
                    foreach (char c in input)
                    {
                        if (Char.IsLetter(c) || c == ' ')
                        {
                            isString = true;
                            break;
                        }
                    }
                    if (isString)
                    {
                        Console.WriteLine("It is a valid string");
                    }
                    else
                    {
                        Console.WriteLine("It is an Invalid string");
                    }

                    break;

                case 2:
                    int inputInt;
                    bool isInteger = int.TryParse(input, out inputInt);

                    if (isInteger)
                    {
                        Console.WriteLine("It is a valid integer");
                    }
                    else
                    {
                        Console.WriteLine("It is an Invalid integer");
                    }

                    break;


                case 3:
                    bool isBoolean = false;
                    string lowerInput = input.ToLower();
                    if (lowerInput == "true" || lowerInput == "false")
                    {
                        isBoolean = true;
                    }

                    if (isBoolean)
                    {
                        Console.WriteLine("It is a valid boolean");
                    }
                    else
                    {
                        Console.WriteLine("It is an Invalid boolean");
                    }



                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }


        }
    }
}