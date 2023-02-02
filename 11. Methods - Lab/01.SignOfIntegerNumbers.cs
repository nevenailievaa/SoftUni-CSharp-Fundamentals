using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int n = int.Parse(Console.ReadLine());
        //OUTPUT
        PrintNumberSign(n);
    }
    //ACTION
    static void PrintNumberSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}
