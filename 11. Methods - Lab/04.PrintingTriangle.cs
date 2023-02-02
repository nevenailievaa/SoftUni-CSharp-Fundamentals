using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int inputNumber = int.Parse(Console.ReadLine());

        //OUTPUT
        TriangleOne(inputNumber);
        TriangleTwo(inputNumber);
    }

    //ACTION
    //First Half
    static void TriangleOne(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
    //Second Half
    static void TriangleTwo(int n)
    {
        for (int i = n-1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
