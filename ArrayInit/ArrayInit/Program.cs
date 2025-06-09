namespace ArrayInit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 80;
            grades[1] = 90;

            int[] ages = new int[5];

            int[] gradesChem = { 80, 90, 100, 70, 60 };
            int[] gradesMath = new int[] { 80, 90, 100, 70, 60 };

            int[] gradesPhy;

            //gradesPhy = { 80, 90, 100, 70, 60 };
            // this line is wrong

            gradesPhy = new int[] { 80, 90, 100, 70, 60 }; // this line is correct


            int numStudents = ages.Length;
            Console.WriteLine("Number of students is " + numStudents);


            Console.WriteLine(grades[0]);

        }
    }
}