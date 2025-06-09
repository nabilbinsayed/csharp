using System;
using System.ComponentModel.DataAnnotations;
namespace BoxProperties
{   

    class Box
    {
        //public int width;
        private int height, length, volume; 

        public Box(int height, int width)
        {
            Height = height;
            Width = width; 
        }

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return this.height; 
            }
            set
            {
                if (value < 0) {
                    this.height = -value; 
                }
                else
                {
                    this.height = value;
                }
            }
        }

        //public Box(int width)
        //{
        //    this.width = width;
        //}

        public void SetLength()
        {
            Console.Write("Enter length: ");
            bool isValidLength = int.TryParse(Console.ReadLine(), out this.length);
            if (!isValidLength || this.length <= 0)
            {
                Console.WriteLine("Invalid length. Setting to default value of 5.");
                this.length = 5; // Default value
            }
        }

        public int GetLength()
        {
            return this.length; 
        }

        public int Volume
        {
            get
            {
                return this.height * this.Width * this.length; 
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Length: {this.length}, Width: {Width}, Height: {Height}, Volume: {Volume}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Box boxDemo = new Box(3, 5);
            boxDemo.SetLength();
            Console.WriteLine($"Length is {boxDemo.GetLength()}");
            boxDemo.DisplayInfo();
            // Console.WriteLine($"Length is {boxDemo.length}"); 
            // Uncommenting the above line will cause a compilation error because 'length' is private.
            // cannot set it neither get it this way




        }
    }
}