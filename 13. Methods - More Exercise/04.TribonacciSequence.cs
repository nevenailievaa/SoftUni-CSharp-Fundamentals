using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int num = int.Parse(Console.ReadLine());
        int[] arrayNumbers = new int[num];

        //OUTPUT
        Console.WriteLine(String.Join(" ", TribonacciSequence(num, arrayNumbers)));
    }

    //ACTION
    static int[] TribonacciSequence(int num, int[] arrayNumbers)
    {
        arrayNumbers = new int[num];
        arrayNumbers[0] = 1;

        for (int i = 1; i < num; i++)
        {
            if (i == 1)
            {
                arrayNumbers[i] = i;
            }
            else if (i == 2)
            {
                arrayNumbers[i] = i;
            }
            else
            {
                arrayNumbers[i] = arrayNumbers[i - 1] + arrayNumbers[i - 2] + arrayNumbers[i - 3];
            }
        }

        //OUTPUT
        return arrayNumbers;
    }
}