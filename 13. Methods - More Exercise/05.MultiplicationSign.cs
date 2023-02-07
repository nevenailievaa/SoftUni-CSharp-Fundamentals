using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        //OUTPUT
        Console.WriteLine(PositiveOrNegative(numOne, numTwo, numThree));
    }

    //ACTION
    static string PositiveOrNegative(int numOne, int numTwo, int numThree)
    {
        int negativeNumsCnt = 0;

        //Zero Checher
        if (numThree == 0 || numTwo == 0 || numThree == 0)
        {
            return "zero";
        }

        //Negative Numbers Counter
        if (numOne < 0)
        {
            negativeNumsCnt++;
        }
        if (numTwo < 0)
        {
            negativeNumsCnt++;
        }
        if (numThree < 0)
        {
            negativeNumsCnt++;
        }

        //Positive Or Negative Sum
        if (negativeNumsCnt % 2 == 0)
        {
            return "positive";
        }
        else
        {
            return "negative";
        }
    }
}