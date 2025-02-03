namespace MicrosoftLearn.guidedProject
{
    public class Challenge
    {
        static int[] Grade = new int[5]{4, 3, 3, 3, 4};
        static string[] Courses = new string[5]{
            "English 101",
            "Algebra 101",
            "Biology 101",
            "Computer Science I",
            "Psychology 101"
        };
        static int[] CreditHours = new int[5]{3, 3, 4, 4, 3};

        static float calculateGrade(int[] grade, int[] creditHours){
            int gradeSum = 0;
            int totalCreditHours = creditHours.Sum();

            for(int i = 0; i < Grade.Length; i++){
                gradeSum += grade[i] * creditHours[i];
            }

            return gradeSum / (float)totalCreditHours;
            }

        public static void Main(string[] args)
        {
            float sophiaResult = calculateGrade(Grade, CreditHours);

            Console.WriteLine("Student: Sophia Johnson\n");

            Console.WriteLine("Course\t\t\tGrade\tCredit Hours\n");

            for(int i = 0; i < 5; i++){
                string t = "\t\t";
                if (Courses[i].Count() > 15) {
                    t = "\t";
                }
                Console.WriteLine($"{Courses[i]}{t}{Grade[i]}\t{CreditHours[i]}");
            }

            Console.WriteLine($"\nFinal GPA:\t\t{sophiaResult:f}");
        }
    }
}