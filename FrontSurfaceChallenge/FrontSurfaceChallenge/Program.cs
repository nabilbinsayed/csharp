using System; 
namespace FrontSurface
{   

    public class Box
    {
        private int height, width, length, surfaceArea; 

        public int Height
        {
            get
            {
                return this.height;             
            }
            set
            {
                if(value < 0)
                {
                    this.height = -value; 
                }
                else
                {
                    this.height = value;
                }
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    this.width = -value;
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value < 0)
                {
                    this.length = -value;
                }
                else
                {
                    this.length = value;
                }
            }
        }
        public int SurfaceArea
        {
            get
            {
                return 2 * (Height * Width + Height * Length + Width * Length);
            }
        }
        public Box(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Box box1 = new Box(2, 4, -5);

            Console.WriteLine($"The height is: {box1.Height}, length: {box1.Length}, width: {box1.Width}, Surface area is: {box1.SurfaceArea} ");


        }
    }
}