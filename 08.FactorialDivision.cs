using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        //ACTION
        double firstNumFactorial = (double)(NumberFactorial(firstNumber));
        double secondNumFactorial = (double)NumberFactorial(secondNumber);

        //OUTPUT
        Console.WriteLine($"{firstNumFactorial / secondNumFactorial:f2}");
    }

    //ACTION
    static double NumberFactorial(int number)
    {
        double result = 1.00;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}