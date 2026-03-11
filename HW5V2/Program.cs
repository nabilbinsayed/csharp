using System;
using System.Collections.Generic;

namespace HW5
{
    // Abstract base class for all university subjects
    public abstract class Subject
    {
        // Static variable to auto-increment SubjectId across all subjects
        private static int nextSubjectId = 1;
        
        // Public property for Subject ID
        public int SubjectId { get; private set; }
        
        // Protected field and public property for title
        protected string title;
        public string Title
        {
            get { return title; }
            private set { title = value; } // Made private to prevent external modification
        }

        // Abstract method to be implemented by derived classes
        public abstract string GetDetails();

        // Constructor using 'this' keyword
        public Subject(string title)
        {
            this.SubjectId = nextSubjectId++;
            this.title = title;
        }
    }

    // Course class inheriting from Subject
    public class Course : Subject
    {
        // Static variable to track number of Course instances
        public static int CourseCount { get; private set; } = 0;
        
        // Private field and public property for credit hours
        private int creditHours;
        public int CreditHours
        {
            get { return creditHours; }
            private set { creditHours = value; } // Made private to prevent external modification
        }

        // Constructor using 'this' keyword
        public Course(string title, int creditHours) : base(title)
        {
            this.creditHours = creditHours;
            CourseCount++; // Increment static counter
        }

        // Override abstract method to return course details
        public override string GetDetails()
        {
            return $"{SubjectId}\tCourse\t\tTitle: {Title}, Credits: {CreditHours}";
        }
    }

    // Seminar class inheriting from Subject
    public class Seminar : Subject
    {
        // Static variable to track number of Seminar instances
        public static int SeminarCount { get; private set; } = 0;
        
        // Private field and public property for duration
        private float duration;
        public float Duration
        {
            get { return duration; }
            private set { duration = value; } // Made private to prevent external modification
        }

        // Constructor using 'this' keyword
        public Seminar(string title, float duration) : base(title)
        {
            this.duration = duration;
            SeminarCount++; // Increment static counter
        }

        // Override abstract method to return seminar details
        public override string GetDetails()
        {
            return $"{SubjectId}\tSeminar\t\tTitle: {Title}, Duration: {Duration} hr";
        }
    }

    // Lab class inheriting from Subject
    public class Lab : Subject
    {
        // Static variable to track number of Lab instances
        public static int LabCount { get; private set; } = 0;
        
        // Private field and public property for equipment count
        private int equipmentCount;
        public int EquipmentCount
        {
            get { return equipmentCount; }
            private set { equipmentCount = value; } // Made private to prevent external modification
        }

        // Constructor using 'this' keyword
        public Lab(string title, int equipmentCount) : base(title)
        {
            this.equipmentCount = equipmentCount;
            LabCount++; // Increment static counter
        }

        // Override abstract method to return lab details
        public override string GetDetails()
        {
            return $"{SubjectId}\tLab\t\tTitle: {Title}, Equipment: {EquipmentCount}";
        }
    }

    // Main program class
    class Program
    {
        // Dynamic lists to store different subject types
        private static List<Course> courses = new List<Course>();
        private static List<Seminar> seminars = new List<Seminar>();
        private static List<Lab> labs = new List<Lab>();

        static void Main(string[] args)
        {
            // Main program loop
            while (true)
            {
                DisplayMenu();
                int option = GetMenuChoice();
                
                switch (option)
                {
                    case 1:
                        AddCourse();
                        break;
                    case 2:
                        AddSeminar();
                        break;
                    case 3:
                        AddLab();
                        break;
                    case 4:
                        ListSubjects();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                
                Console.WriteLine(); // Add blank line for better readability
            }
        }

        // Display the main menu
        private static void DisplayMenu()
        {
            Console.WriteLine("University Course Management System Menu:");
            Console.WriteLine("1. Add a Course");
            Console.WriteLine("2. Add a Seminar");
            Console.WriteLine("3. Add a Lab");
            Console.WriteLine("4. List Subjects");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
        }

        // Get and validate menu choice
        private static int GetMenuChoice()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 5)
                {
                    return choice;
                }
                Console.Write("Invalid input. Please enter a number between 1 and 5: ");
            }
        }

        // Add a new course with input validation
        private static void AddCourse()
        {
            string title = GetValidTitle();
            int creditHours = GetValidCreditHours();
            
            courses.Add(new Course(title, creditHours));
            Console.WriteLine("Course added successfully.");
        }

        // Add a new seminar with input validation
        private static void AddSeminar()
        {
            string title = GetValidTitle();
            float duration = GetValidDuration();
            
            seminars.Add(new Seminar(title, duration));
            Console.WriteLine("Seminar added successfully.");
        }

        // Add a new lab with input validation
        private static void AddLab()
        {
            string title = GetValidTitle();
            int equipmentCount = GetValidEquipmentCount();
            
            labs.Add(new Lab(title, equipmentCount));
            Console.WriteLine("Lab added successfully.");
        }

        // Validate and get title input
        private static string GetValidTitle()
        {
            while (true)
            {
                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(title))
                {
                    return title.Trim();
                }
                
                Console.WriteLine("Invalid title. Please enter a non-empty string.");
            }
        }

        // Validate and get credit hours input
        private static int GetValidCreditHours()
        {
            while (true)
            {
                Console.Write("Enter credit hours: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int creditHours) && creditHours > 0)
                {
                    return creditHours;
                }
                
                Console.WriteLine("Invalid input. Please enter a positive integer for credit hours.");
            }
        }

        // Validate and get duration input
        private static float GetValidDuration()
        {
            while (true)
            {
                Console.Write("Enter duration: ");
                string input = Console.ReadLine();
                
                if (float.TryParse(input, out float duration) && duration > 0)
                {
                    return duration;
                }
                
                Console.WriteLine("Invalid input. Please enter a positive number for duration.");
            }
        }

        // Validate and get equipment count input
        private static int GetValidEquipmentCount()
        {
            while (true)
            {
                Console.Write("Enter equipment count: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int equipmentCount) && equipmentCount > 0)
                {
                    return equipmentCount;
                }
                
                Console.WriteLine("Invalid input. Please enter a positive integer for equipment count.");
            }
        }

        // List all subjects grouped by type, sorted by Subject ID
        private static void ListSubjects()
        {
            // Sort lists by SubjectId before displaying
            courses.Sort((c1, c2) => c1.SubjectId.CompareTo(c2.SubjectId));
            seminars.Sort((s1, s2) => s1.SubjectId.CompareTo(s2.SubjectId));
            labs.Sort((l1, l2) => l1.SubjectId.CompareTo(l2.SubjectId));

            // Display courses using foreach loop
            Console.WriteLine("--- Course List ---");
            Console.WriteLine("ID\tType\t\tDetails");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.GetDetails());
            }

            // Display seminars using foreach loop
            Console.WriteLine("--- Seminar List ---");
            Console.WriteLine("ID\tType\t\tDetails");
            foreach (Seminar seminar in seminars)
            {
                Console.WriteLine(seminar.GetDetails());
            }

            // Display labs using foreach loop
            Console.WriteLine("--- Lab List ---");
            Console.WriteLine("ID\tType\t\tDetails");
            foreach (Lab lab in labs)
            {
                Console.WriteLine(lab.GetDetails());
            }

            // Display totals using static variables
            Console.WriteLine($"Total Courses: {Course.CourseCount}");
            Console.WriteLine($"Total Seminars: {Seminar.SeminarCount}");
            Console.WriteLine($"Total Labs: {Lab.LabCount}");
        }
    }
}