using System;
public class Program
{
    static void Main()
    {
        //INPUT
        string input = Console.ReadLine();

        //OUTPUT
        MiddleCharacters(input);
    }

    //ACTION
    static void MiddleCharacters(string input)
    {
        char[] chars = input.ToCharArray();

        char firstMiddleChar;
        char secondMiddleChar;

        if (input.Length % 2 == 0)
        {
            firstMiddleChar = chars[input.Length/2 - 1];
            secondMiddleChar = chars[input.Length/2];
            Console.WriteLine($"{firstMiddleChar}{secondMiddleChar}");
        }
        else
        {
            firstMiddleChar = chars[input.Length/2];
            Console.WriteLine(firstMiddleChar);
        }
    }
}