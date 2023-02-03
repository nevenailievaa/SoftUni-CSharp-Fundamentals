using System;
public class Program
{
    static void Main()
    {
        //INPUT
        string inputString = Console.ReadLine();
        int repeatCount = int.Parse(Console.ReadLine());

        //OUTPUT
        Repeat(inputString, repeatCount);
    }

    //ACTION
    static void Repeat(string inputString, int repeatCount)
    {
        for (int i = 1; i <= repeatCount; i++)
        {
            Console.Write(inputString);
        }
    }
}