namespace MultiDim
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[,] matrix1; // Declare a 2D array (matrix) of strings
            string[,,] cube1; // Declare a 3D array (cube) of strings

            int[,] matrix2 = new int[,] // unspecified dimensions
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine($"Central value is {matrix2[1, 1]}");
            Console.WriteLine($"7 = {matrix2[2, 0]}");

            int[,] matrix3 = new int[2, 2] // 2 row, 2 columns
            {
                { 1, 2 },
                { 3, 4 }
            };

        }
    }
}