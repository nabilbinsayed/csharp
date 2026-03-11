using System;
using System.Collections.Generic;

namespace HW7
{
  class Employee
  {
    private static int employeeCount = 100; // used for tracking ID

    public int ID { get; set; }


    public string Name { get; set; }

    public Employee()
    {

    }

    public Employee(string name)
    {
      ID = ++employeeCount; // increments the ID for every instance of the Employee class
      this.Name = name;
    }

    public virtual void DisplayInfo()
    {
      // System.Console.WriteLine($"Name: {Name}");
    }
    public virtual int CalculateBonus()
    {
      return 1000; // base bonus
    }

    public virtual int CalculateBonus(int teamSize)
    {
      return 1000; // had to include different ways of implement the same method for different data types
    }
    public virtual int CalculateBonus(string lang)
    {
      return 1000;
    }

  }

  // ---------------------------------------------------------------
  class Manager : Employee
  {
    public int TeamSize { get; set; }

    public override void DisplayInfo()
    {
      System.Console.WriteLine($"[Manager] ID: {ID:D3}, Name: {Name}, Team Size: {TeamSize}"); // used D3 for printing 3 digits
      System.Console.WriteLine($"Bonus: ${CalculateBonus(TeamSize)}");
    }
    public override int CalculateBonus(int teamSize)
    {
      return base.CalculateBonus() + 200 * teamSize; // used base keyword for better consistency across code, rather than blindly 1000
    }

    public Manager(string name, int teamSize) : base(name) // usage of constructor chaining using base keyword 
    {
      this.TeamSize = teamSize;
    }
  }

  // ------------------------------------------------------------------------------

  class Developer : Employee
  {
    public string ProgrammingLanguage { get; set; }
    public override void DisplayInfo()
    {
      System.Console.WriteLine($"[Developer] ID: {ID:D3}, Name: {Name}, Language : {ProgrammingLanguage}");
      System.Console.WriteLine($"Bonus: ${CalculateBonus(ProgrammingLanguage)}");
    }

    public override int CalculateBonus(string lang)
    {
      if (lang == "C#")
      {
        return base.CalculateBonus() + 500; // used base keyword for better consistency across code, rather than blindly 1000
      }
      else
      {
        return base.CalculateBonus() + 300;
      }
    }

    public Developer(string name, string lang) : base(name) // usage of constructor chaining using base keyword
    {
      ProgrammingLanguage = lang;
    }

  }
  class Program
  {
    public static void Main(string[] args)
    {
      List<Employee> company = new List<Employee>();

      company.Add(new Manager("Abid", 5));
      company.Add(new Developer("Tahsan", "C#"));
      company.Add(new Developer("Rabbi", "Python"));

      // found to show correct outputs

      foreach (Employee emp in company)
      {
        emp.DisplayInfo();
      }

    }
  }
}