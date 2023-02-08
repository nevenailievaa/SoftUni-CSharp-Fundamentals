using System;

namespace _01.SoftuniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int studentsPerHourOne = int.Parse(Console.ReadLine());
            int studentsPerHourTwo = int.Parse(Console.ReadLine());
            int studentsPerHourThree = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            //ACTION
            int studentsPerHourSum = studentsPerHourOne + studentsPerHourTwo + studentsPerHourThree;

            int currentStudentsCount = studentsCount;
            int hoursCount = 0;

            //Hours Counter
            while (currentStudentsCount > 0)
            {
                hoursCount++;
                currentStudentsCount -= studentsPerHourSum;
                if (hoursCount % 4 == 0)
                {
                    hoursCount++;
                }
            }

            //OUTPUT
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
