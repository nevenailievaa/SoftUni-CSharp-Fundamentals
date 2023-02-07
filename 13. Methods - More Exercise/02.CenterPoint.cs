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

        //OUTPUT
        if (FirstPointCoordinates(x1, y1) < SecondPointCoordinates(x2, y2))
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else if (FirstPointCoordinates(x1, y1) > SecondPointCoordinates(x2, y2))
        {
            Console.WriteLine($"({x2}, {y2})");
        }
        else if (FirstPointCoordinates(x1, y1) == SecondPointCoordinates(x2, y2))
        {
            Console.WriteLine($"({x1}, {y1})");
        }
    }

    //ACTION
    static double FirstPointCoordinates(double x1, double y1)
    {
        double pointsSum = Math.Abs(x1) + Math.Abs(y1);
        return pointsSum;
    }
    static double SecondPointCoordinates(double x2, double y2)
    {
        double pointsSum = Math.Abs(x2) + Math.Abs(y2);
        return pointsSum;
    }
}