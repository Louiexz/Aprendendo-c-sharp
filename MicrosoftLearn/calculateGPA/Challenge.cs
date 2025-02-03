namespace MicrosoftLearn.guidedProject
{
    public class Challenge
    {
        static int[] Sophia = new int[5]{93, 87, 98, 95, 100};

        static int[] Nicolas = new int[5]{80, 83, 82, 88, 85};

        static int[] Zahirah = new int[5]{ 84, 96, 73, 85, 79};

        static int[] Jeong = new int[5]{ 90, 92, 98, 100, 97 };

        static float calculateGrade(int[] student, out string Grade){
            Grade = "F";
            float result = student.Sum() / 5F;

            if (result > 90){
                Grade = "A";
            } else if (result > 80){
                Grade = "B";
            } else if (result > 70){
                Grade = "C";
            }

            return result;
        }

        static string? sophiaGrade, nicolasGrade, zahirahGrade, jeongGrade;

        public static void Main(string[] args)
        {
            float sophiaResult = calculateGrade(Sophia, out sophiaGrade);
            float nicolasResult = calculateGrade(Nicolas, out nicolasGrade);
            float zahirahResult = calculateGrade(Zahirah, out zahirahGrade);
            float jeongResult = calculateGrade(Jeong, out jeongGrade);

            Console.WriteLine("Student\t\tGrade\n");

            Console.WriteLine($"Sophia:\t\t{(int)sophiaResult}\t{sophiaGrade}");
            Console.WriteLine($"Nicolas:\t{nicolasResult}\t{nicolasGrade}");
            Console.WriteLine($"Zahirah:\t{zahirahResult}\t{zahirahGrade}");
            Console.WriteLine($"Jeong:\t\t{jeongResult}\t{jeongGrade}");
        }
    }
}