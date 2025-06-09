namespace ArrayInit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];

            int i = 10;

            for (i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * i;
                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine();

            foreach (int j in numbers)
            {
                Console.WriteLine(j * j * j);
            }

            Console.WriteLine();
            string[] names = new string[3] { "Alice", "Bob", "Charlie" };

            int counter = 0;

            foreach (string name in names)
            {
                Console.WriteLine($"Member{counter+1} is {name}. Hello!");
                counter++; 
            }

            Console.WriteLine($"Number of people: {counter}");


        }
    }
}