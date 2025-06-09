using System;
namespace Exam
{
    public class Rectangle
    {
        int Width, Height; 
        public Rectangle(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public int Area()
        {
            return Width * Height;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(2, 3);
            Rectangle rec2 = new Rectangle(4, 5);

            Console.WriteLine("Enter 1 to view area of Rectangle 1, 2 for Rectangle 2");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Area of Rectangle 1 is {rec1.Area()}");
                    break;
                case 2:
                    Console.WriteLine($"Area of Rectangle 2 is {rec2.Area()}");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            int areaBigger = rec1.Area() > rec2.Area() ? rec1.Area() : rec2.Area();
            Console.WriteLine($"Area of bigger rectangle is {areaBigger}");

            if (areaBigger == rec1.Area())
            {
                Console.WriteLine("Rectangle 1 is bigger");
            }
            else
            {
                Console.WriteLine("Rectangle 2 is bigger");

            }
        }
    }
}