using Microsoft.VisualBasic;
using System;
public class Program
{
    static void Main()
    {
        //INPUT
        string typeValues = Console.ReadLine();

        //Value Checker
        if (typeValues == "int")
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int greaterValue = GetMax(firstNumber, secondNumber);
            Console.WriteLine(greaterValue);
        }
        else if(typeValues == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char greaterValue = GetMax(firstChar, secondChar);
            Console.WriteLine(greaterValue);

        }
        else if(typeValues == "string")
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string greaterValue = GetMax(firstString, secondString);
            Console.WriteLine(greaterValue);
        }
    }

    //ACTION
    //Int Compare
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        return secondNumber;
    }
    //Char Compare
    static char GetMax(char firstChar, char secondChar)
    {
        if (firstChar > secondChar)
        {
            return firstChar;
        }
        return secondChar;
    }
    //String Compare
    static string GetMax(string firstString, string secondString)
    {
        int biggerString = firstString.CompareTo(secondString);

        if (biggerString > 0)
        {
            return firstString;
        }
        return secondString;
    }
}