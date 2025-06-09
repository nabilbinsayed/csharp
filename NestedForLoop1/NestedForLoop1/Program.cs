namespace ForLoop
{
    public class Program
    {
        static int[,] demoArr = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        static void Main(string[] args)
        {
            for (int i = 0; i < demoArr.GetLength(0); i++)
            {
                for (int j = 0; j < demoArr.GetLength(1); j++)
                {
                    Console.Write($"{demoArr[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < demoArr.GetLength(0); i++)
            {
                for (int j = 0; j < demoArr.GetLength(1); j++)
                {
                    if (demoArr[i, j] % 2 == 0)
                    {
                        Console.Write($"{demoArr[i, j]} ");

                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}