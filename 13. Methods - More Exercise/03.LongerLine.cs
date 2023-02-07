using System;
public class Program
{
    static void Main()
    {
        //INPUT
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double a1 = double.Parse(Console.ReadLine());
        double b1 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());

        //ACTION
        double sumOne = GroupPointsSum(x1, y1, x2, y2);
        double sumTwo = GroupPointsSum(a1, b1, a2, b2);

        //OUTPUT
        //Comparing the two 4x groups
        if (sumOne >= sumTwo)
        {
            double resultOne = CoordinatesSum(x1, y1);
            double resultTwo = CoordinatesSum(x2, y2);

            //Compasring the first two smaller groups
            if (resultOne <= resultTwo)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        else if (sumOne < sumTwo)
        {
            double resultOne = CoordinatesSum(a1, b1);
            double resultTwo = CoordinatesSum(a2, b2);

            //Compasring the second two smaller groups
            if (resultOne <= resultTwo)
            {
                Console.WriteLine($"({a1}, {b1})({a2}, {b2})");
            }
            else
            {
                Console.WriteLine($"({a2}, {b2})({a1}, {b1})");
            }
        }
    }

    //CALCULATIONS
    //Points Sum
    static double GroupPointsSum(double firstNum, double secondNum, double thirdNum, double fourthNum)
    {
        return Math.Abs(firstNum) + Math.Abs(secondNum) + Math.Abs(thirdNum) + Math.Abs(fourthNum);
    }


    //Comparing Group Of Points
    static double CoordinatesSum(double firstNum, double secondNum)
    {
        return Math.Abs(firstNum) + Math.Abs(secondNum);
    }
}