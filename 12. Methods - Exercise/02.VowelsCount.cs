using System;
public class Program
{
    static void Main()
    {
        //INPUT
        string input = Console.ReadLine();

        //OUTPUT
        Console.WriteLine(VowelsCount(input));
    }

    //ACTION
    static int VowelsCount(string input)
    {
        char[] inputArray = input.ToCharArray();
        int vowelsCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (inputArray[i] == 'A' || inputArray[i] == 'E' || inputArray[i] == 'I'
                || inputArray[i] == 'O' || inputArray[i] == 'U' || inputArray[i] == 'a'
                || inputArray[i] == 'e' || inputArray[i] == 'i' || inputArray[i] == 'o'
                || inputArray[i] == 'u')
            {
                vowelsCount++;
            }
        }
        return vowelsCount;
    }
}