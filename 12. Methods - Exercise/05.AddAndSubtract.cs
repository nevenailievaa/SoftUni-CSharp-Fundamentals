using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        //ACTION
        int d = Sum(a, b);
        int result = Subtract(d, c);

        //OUTPUT
        Console.WriteLine(result);
    }

    //ACTION
    static int Sum(int a, int b)
    {
        return a+b;
    }
    static int Subtract(int d, int c)
    {
        return d - c;
    }
}