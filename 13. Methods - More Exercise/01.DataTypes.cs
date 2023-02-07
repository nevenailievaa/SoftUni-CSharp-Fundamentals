using System;
public class Program
{
    static void Main()
    {
        //INPUT
        string inputType = Console.ReadLine();

        //OUTPUT
        if (inputType == "int")
        {
            int input = int.Parse(Console.ReadLine());
            Integers(input);
        }
        else if (inputType == "real")
        {
            double input = double.Parse(Console.ReadLine());
            RealNums(input);
        }
        else if (inputType == "string")
        {
            string input = Console.ReadLine();
            Strings(input);
        }
    }

    //ACTION
    static void Integers(int input)
    {
        Console.WriteLine(input * 2);
    }
    static void RealNums(double input)
    {
        Console.WriteLine($"{(input * 1.5):f2}");
    }
    static void Strings(string input)
    {
        Console.WriteLine($"${input}$");
    }
}