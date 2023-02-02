using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int inputNumberOne = int.Parse(Console.ReadLine());
        int inputNumberTwo = int.Parse(Console.ReadLine());

        //OUTPUT
        AreaCalculation(inputNumberOne, inputNumberTwo);
    }

    //ACTION
    static void AreaCalculation(int n1, int n2)
    {
        Console.WriteLine(n1 * n2);
    }
}
