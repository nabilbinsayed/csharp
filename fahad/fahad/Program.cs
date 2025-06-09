using System;

//geometric shape

namespace GeometricShape
{
    public class addCircle
    {
        public int shapeID;
        public double diameter;

    }

    public class addRect
    {
        public int shapeID;
        public double height;
        public double width;
    }

    public class addCube
    {
        public int shapeID;
        public double height;
        public double width;
        public double depth;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //circle array

            addCircle[] circle = new addCircle[100];

            //rectangle array
            addRect[] rectangle = new addRect[100];

            //cube array
            addCube[] cube = new addCube[100];

            //menu
            Console.WriteLine("Please select a option : \n");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Cube");
            Console.WriteLine("4. List Items");
            Console.WriteLine("5. Exit\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            int c = 0, r = 0, cu = 0;


            while (true)


            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have selected Circle");

                        circle[c] = new addCircle();
                        circle[c].shapeID = c + 1;
                        Console.Write("Enter the diameter : ");
                        circle[c].diameter = Convert.ToDouble(Console.ReadLine());
                        c++;

                        break;

                    case 2:

                        Console.WriteLine("You have selected Rectangle");

                        rectangle[r] = new addRect();
                        rectangle[r].shapeID = r + 1;
                        Console.Write("Enter the height:");
                        rectangle[r].height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the width:");
                        rectangle[r].width = Convert.ToDouble(Console.ReadLine());
                        r++;

                        break;

                    case 3:
                        Console.WriteLine("You have selected Cube");

                        cube[cu] = new addCube();
                        cube[cu].shapeID = cu + 1;
                        Console.Write("Enter the height : ");
                        cube[cu].height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the width:");
                        cube[cu].width = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the depth:");
                        cube[cu].depth = Convert.ToDouble(Console.ReadLine());
                        cu++;

                        break;

                    case 4:

                        Console.WriteLine("---Circle---");
                        Console.WriteLine("ID    TYPE    Dimension");
                        Console.WriteLine("=======================");
                        for (int i = 0; i < c; i++)
                        {
                            Console.WriteLine(circle[i].shapeID + "    Circle    " + circle[i].diameter);
                        }

                        Console.WriteLine("---Rectangle---");
                        Console.WriteLine("ID    TYPE    Dimension(H X W)");
                        Console.WriteLine("==============================");
                        for (int i = 0; i < r; i++)
                        {
                            Console.WriteLine(rectangle[i].shapeID + "    Rectangle    " + rectangle[i].height + " X " + rectangle[i].width);
                        }

                        Console.WriteLine("---Cube---");
                        Console.WriteLine("ID    TYPE    Dimension(H X W X D)");
                        Console.WriteLine("==================================");
                        for (int i = 0; i < c; i++)
                        {
                            Console.WriteLine(cube[i].shapeID + "    Cube    " + cube[i].height + " X " + cube[i].width + " X " + cube[i].depth);
                        }

                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }

                Console.WriteLine("Please select a option :");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Cube");
                Console.WriteLine("4. List Items");
                Console.WriteLine("5. Exit\n");

                choice = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}