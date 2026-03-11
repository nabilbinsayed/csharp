
using System;

namespace HW5
{

  //------------------------------
  public abstract class Subject
  {
    protected static int subjectID = 0;

    protected string title;
    public string Title
    {
      get
      {
        return title;
      }
      set
      {
        while (true)
        {
          if (!string.IsNullOrEmpty(value))
          {
            title = value;
            break;
          }
          else
          {
            System.Console.WriteLine("Invalid input, please try again");
          }
        }
      }
    }

    public abstract string GetDetails();

    public Subject(string title)
    {
      subjectID++;
      this.Title = title; 
    }

  }

  // --------------------------

  public class Course : Subject
  {
    List<Course> CourseList = new List<Course>();

    static int CourseCount = 0;

    private int creditHours;

    public int CreditHours
    {
      get
      {
        return creditHours;
      }
      set
      {
        while (true)
        {
          int trash;
          if (value > 0 && int.TryParse(value.ToString(), out trash))
          {
            creditHours = value;
            break;
          }
          else
          {
            System.Console.WriteLine("Invalid input, please try again");
          }
        }
      }
    }

    public override string GetDetails()
    {
      return $"{subjectID}    Course   Title: {Title}, Credits: {CreditHours}";
    }
    public void AddCourse()
    {
      CourseCount++;
      string title;
      int crHr;
      System.Console.Write("Enter title: ");
      title = Console.ReadLine();
      System.Console.Write("Enter credit hours: ");
      crHr = Convert.ToInt32(Console.ReadLine());
      CourseList.Add(new Course(title, crHr));

      System.Console.WriteLine("Course added successfully");


    }

    public Course(string title, int creditHr) : base(title)
    {
      CreditHours = creditHr; 
    }
    
  }

  // ----------------------------------

  public class Seminar : Subject
  {
    List<Seminar> SeminarList = new List<Seminar>();

    static int seminarCount = 0;
    private float duration;
    public float Duration
    {
      get
      {
        return duration;
      }
      set
      {
        while (true)
        {
          if (value > 0)
          {
            duration = value;
            break;
          }
          else
          {
            System.Console.WriteLine("Invalid input, please try again");
          }
        }
      }
    }

    public override string GetDetails()
    {
      return $"{subjectID}    Seminar   Title: {Title}, Duration: {Duration} hr";
    }
    public void AddSeminar()
    {
      seminarCount++;

      string title;
      float durn;
      System.Console.Write("Enter title: ");
      title = Console.ReadLine();
      System.Console.Write("Enter duration: ");
      durn = (float)Convert.ToDouble(Console.ReadLine());
      SeminarList.Add(new Seminar(title, durn));

      System.Console.WriteLine("Course added successfully");


    }

    public Seminar(string title, float duration): base(title)
    {
      Duration = duration; 
    }

    


  }

  // ---------------------------

  public class Lab : Subject
  {
    List<Lab> LabList = new List<Lab>();
    static int labCount = 0;
    private int eqCount;
    public int EqCount
    {
      get
      {
        return eqCount;
      }
      set
      {
        while (true)
        {
          int trash;
          if (value > 0 && int.TryParse(value.ToString(), out trash))
          {
            eqCount = value;
            break;
          }
          else
          {
            System.Console.WriteLine("Invalid input, please try again");
          }
        }
      }
    }

    public override string GetDetails()
    {
      return $"{subjectID}    Lab   Title: {Title}, Equipment: {EqCount}";
    }

    public void AddLab()
    {
      labCount++;

      string title;
      int eqcnt;
      System.Console.Write("Enter title: ");
      title = Console.ReadLine();
      System.Console.Write("Enter number of equipments: ");
      eqcnt = Convert.ToInt32(Console.ReadLine());
      LabList.Add(new Lab(title, eqcnt));

      System.Console.WriteLine("Lab added successfully");


    }

    public Lab(string title, int eqCount) : base(title)
    {
      this.EqCount = eqCount; 
    }

    
  }

  class Program
  {
    static void Main(string[] args)
    {
      


      System.Console.WriteLine("University Course Management System Menu:\n1.Add a Course\n2.Add a Seminar\n3.Add a Lab\n4.List Subjects\n5.Exit");
      Console.Write("Select an option: ");
      int option;
      option = Convert.ToInt32(Console.ReadLine());
      switch (option)
      {
        case 1:
          
          break;
        case 2:
          break;
        case 3:
          break;
        case 4:
          break;
        case 5:
          System.Console.WriteLine("Exiting program...");
          return;
      }
    }
  }
}