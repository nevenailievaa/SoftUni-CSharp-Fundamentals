using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int baseNumber = int.Parse(Console.ReadLine());
        int powerNumber = int.Parse(Console.ReadLine());

        //OUTPUT
        MathPower(baseNumber, powerNumber);
    }

    //ACTION
    static void MathPower(int baseNum, int powerNum)
    {
        Console.WriteLine(Math.Pow(baseNum, powerNum));
    }
}