using System; 
namespace TTT
{
    public class Program
    {
        static string[,] field = new string[,]
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game!");
            PrintBoard();
            Player1Choice();

        }

        public static void PrintBoard()
        {
            string[,] board;
            board = new string[15, 15];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = (i * board.GetLength(0) + j + 1).ToString();
                    if (i == 4 || i == 10)
                    {
                        board[i, j] = "-";
                    }
                    else if (j == 4 || j == 10)
                    {
                        board[i, j] = "|";
                    }
                    else
                    {
                        board[i, j] = " ";
                    }

                    board[1, 1] = field[0, 0];
                    board[1, 7] = field[0, 1];
                    board[1, 13] = field[0, 2];
                    board[7, 1] = field[1, 0];
                    board[7, 7] = field[1, 1];
                    board[7, 13] = field[1, 2];
                    board[13, 1] = field[2, 0];
                    board[13, 7] = field[2, 1];
                    board[13, 13] = field[2, 2];


                    System.Console.Write($"{board[i, j]}");
                }
                System.Console.WriteLine();
            }





        }

        public static void Player1Choice()
        {
            // ResultPrint(ProgressCheck());

            if (ResultPrint(ProgressCheck()) == 1)
            {
                return;
            }

            System.Console.Write("Player 1, Choose a field: ");
            string input = Console.ReadLine();
            int inputNum;
            bool isValidNum = int.TryParse(input, out inputNum);

            if (string.IsNullOrEmpty(input) || !isValidNum || (inputNum > 9) || inputNum < 1)
            {
                System.Console.WriteLine("Invalid input. Try again.");
                Player1Choice();
            }
            else
            {
                inputMatch(input, 1);
                PrintBoard();
                Player2Choice();

            }
        }
        public static void Player2Choice()
        {
            // ResultPrint(ProgressCheck());
            if (ResultPrint(ProgressCheck()) == 1)
            {
                return;
            }

            System.Console.Write("Player 2, Choose a field: ");
            string input = Console.ReadLine();
            int inputNum;
            bool isValidNum = int.TryParse(input, out inputNum);

            if (string.IsNullOrEmpty(input) || !isValidNum || (inputNum > 9) || inputNum < 1)
            {
                System.Console.WriteLine("Invalid input. Try again.");
                Player2Choice();
            }
            else
            {
                inputMatch(input, 2);
                PrintBoard();
                Player1Choice();


            }
        }

        public static void inputMatch(string input, int playerNo)
        {
            bool matchFound = false;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (input == field[i, j])
                    {
                        if (playerNo == 1)
                        {
                            field[i, j] = "X";
                            matchFound = true;
                            break;

                        }
                        else if (playerNo == 2)
                        {
                            field[i, j] = "O";
                            matchFound = true;
                            break;
                        }
                    }
                }
            }
            if (!matchFound)
            {
                if (playerNo == 1)
                {
                    System.Console.WriteLine("Invalid input. Try again.");
                    Player1Choice();
                }
                else if (playerNo == 2)
                {
                    System.Console.WriteLine("Invalid input. Try again.");
                    Player2Choice();
                }
            }


        }

        public static int ProgressCheck()
        {
            // returning 1, 2, 3 for: player 1 winning, player 2 winning, and for a draw
            // returning 0 for program to keep on going

            int trashNum;
            bool numFound = false;
            bool matched = false;

            // XXXX(WRONG!!!!!) need to check if the game is drawn already first XXXX
            // The game can be won even at the last shot, where the whole board is filled out and the given code says it is draw. So it must be checked at the end



            // Now checking for crosses matched, initiated

            if (field[0, 0] == "X" && field[1, 1] == "X" && field[2, 2] == "X")
            {
                return 1;
            }
            else if (field[0, 2] == "X" && field[1, 1] == "X" && field[2, 0] == "X")
            {
                return 1;
            }

            else if (field[0, 0] == "O" && field[1, 1] == "O" && field[2, 2] == "O")
            {
                return 2;
            }
            else if (field[0, 2] == "O" && field[1, 1] == "O" && field[2, 0] == "O")
            {
                return 2;
            }

            // checking for crosses matched, done

            // Now checking for rows or columns matched, first for "X"


            else
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        matched = true;
                        if (field[i, j] != "X") // checking for rows
                        {
                            matched = false;
                            break;
                        }
                    }
                    if (matched)
                    {
                        return 1; // if any single one hadn't matched, it would've came out as false
                    }
                }

                for (int i = 0; i < field.GetLength(1); i++)
                {
                    for (int j = 0; j < field.GetLength(0); j++)
                    {
                        matched = true;
                        if (field[j, i] != "X") // checking for columns
                        {
                            matched = false;
                            break;
                        }
                    }
                    if (matched)
                    {
                        return 1;
                    }
                }

                //  same thing for "0": 

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        matched = true;
                        if (field[i, j] != "O")
                        {
                            matched = false;
                            break;
                        }
                    }
                    if (matched)
                    {
                        return 2;
                    }
                }

                for (int i = 0; i < field.GetLength(1); i++)
                {
                    for (int j = 0; j < field.GetLength(0); j++)
                    {
                        matched = true;
                        if (field[j, i] != "O")
                        {
                            matched = false;
                            break;
                        }
                    }
                    if (matched)
                    {
                        return 2;
                    }
                }

                // checking if the board is already filled out, and thus: drawn

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        numFound = int.TryParse(field[i, j], out trashNum);
                        if (numFound)
                        {
                            return 0;
                        }
                    }
                }
                if (!numFound)
                {
                    return 3;
                }

                return 0;
            }




        }

        public static int ResultPrint(int result)
        {
            if (result == 0)
            {
                return 0;
            }
            else if (result == 1)
            {
                System.Console.WriteLine("Player 1 is Winner!");
                return 1;
            }
            else if (result == 2)
            {
                System.Console.WriteLine("Player 2 is Winner!");
                return 1;
            }
            else if (result == 3)
            {
                System.Console.WriteLine("Game Drawn!");
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}