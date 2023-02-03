using System;
public class Program
{
    static void Main()
    {
        //INPUT
        char firstChar = char.Parse(Console.ReadLine());
        char firstCharCopy = firstChar;
        char secondChar = char.Parse(Console.ReadLine());

        //Bigger and Smaller
        if (firstChar > secondChar)
        {
            firstChar = secondChar;
            secondChar = firstCharCopy;
        }

        int charsDistance = Math.Abs(firstChar - secondChar);

        //OUTPUT
        CharactersInRange(firstChar, secondChar, charsDistance);
    }

    //ACTION
    static void CharactersInRange(char firstChar, char secondChar, int distance)
    {
        char[] charArray = new char[distance-1];
        int k = 0;

        for (int i = firstChar +1; i < secondChar; i++)
        {
            charArray[k] = (char)i;
            k++;
        }

        //OUTPUT Without last space
        for (int j = 0; j < distance - 1; j++)
        {
            if (j != distance - 2)
            {
                Console.Write(charArray[j] + " ");
            }
            else
            {
                Console.Write(charArray[j]);
            }
        }
    }
}