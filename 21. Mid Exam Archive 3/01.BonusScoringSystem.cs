using System;

namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            //ACTION
            //Max Attendances
            double maxBonus = double.MinValue;
            int maxBonusStudentAttendances = 0;

            //Zeroes Checker
            if (studentsCount == 0 || lecturesCount == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            //Max Bonus Calculation
            for (int i = 1; i <= studentsCount; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());

                double totalBonus = ((double)studentAttendances / lecturesCount) *
                    (5 + additionalBonus);

                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    maxBonusStudentAttendances = studentAttendances;
                }
            }

            //OUTPUT
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxBonusStudentAttendances} lectures.");
        }
    }
}
