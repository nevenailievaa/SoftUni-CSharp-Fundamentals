using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int inputInteger = int.Parse(Console.ReadLine());

        //OUTPUT
        Matrix(inputInteger);
    }

    //ACTION
    static void Matrix(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                Console.Write(number + " ");
            }
            //New Line
            Console.WriteLine();
        }
    }
}