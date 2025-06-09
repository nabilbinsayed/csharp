using System.Diagnostics;

namespace MemberFinalizerDestructor
{
    class Members
    {
        // member - private field

        private string memberName = ""; // Initialize to avoid CS8618
        private string jobTitle = "";   // Initialize to avoid CS8618
        private int salary;

        // member - public field

        public int age;

        // member - property - exposes jobTitle safely 
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Job Title cannot be null or empty.");
                }
                jobTitle = value;
            }
        }

        public string MemberName
        {
            get
            {
                return memberName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Member name cannot be null or empty.");
                }
                memberName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                age = value;
            }
        }


        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                salary = value;
            }
        }

        // public member method

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary here is {salary}");
        }

        public void Introducing(bool isFriend)
        {
            Console.WriteLine($"Hi, I'm {memberName}, I'm {age} years old. I'm working as a {jobTitle}.");

            if (isFriend)
            {
                SharingPrivateInfo();
            }
        }

        public Members(string memberName, string jobTitle, int salary, int age)
        {
            MemberName = memberName;
            JobTitle = jobTitle;
            Salary = salary;
            Age = age;
        }

        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of member objects");
            Debug.WriteLine("Destruction of member objects");
        }

    }
}
