using System; 
namespace TTT
{
    public class Program
    {
        static bool[,] field = new bool[,]
        {
            { false, false, false },
            { false, false, false },
            { false, false, false }
        };

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game!");
            PrintBoard();
        }

        public static void PrintBoard()
        {
            int[,] board;
            board = new int[9, 9];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = i + j + 1;
                }
            }

            


        }




    }
}