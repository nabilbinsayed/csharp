namespace shapeshapeshape
{
  // Removed invalid List class declaration
  public class Program
  {

    class Circle
    {
      public int ID;
      public double radius;
      public string ShapeName = "circle";
    }

    class Rec
    {
      public int ID;
      public double height, width;

      public string ShapeName = "rectangle";

    }

    class Cube
    {
      public int ID;
      public double height, breadth;


      public string ShapeName = "cube";

    }
    public static void Main()
    {
      int choice, i;
      int[] shapeID = new int[100];
      for (i = 0; i < 100; i++)
      {
        shapeID[i] = 0;
      }
      


      // 1=circle, 2 = rec, 3=cube


      Console.WriteLine("1. Add a circle\n2. Add a rectangle\n3. Add a cube\n4. List items\n5. Exit");
      choice = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(choice);
      switch (choice)
      {
        case 1:
          Console.WriteLine("Enter Radius: ");
          Convert.ToDouble(Console.ReadLine());

          break;
        case 2:
          Console.WriteLine("Enter height: ");
          Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter width: ");
          Convert.ToDouble(Console.ReadLine());

          break;
        case 3:
          Console.WriteLine("Enter height: ");
          Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter width: ");
          Convert.ToDouble(Console.ReadLine());
          Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter breadth: ");
          Convert.ToDouble(Console.ReadLine());

          break;
        case 4:


          break;
        case 5:
          break;
        default:
          Console.WriteLine("Invalid Input");
          break;
      }






    }
  }

  public class List()
  {

  }
}