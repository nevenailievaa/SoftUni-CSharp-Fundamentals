using System;
using System.Linq;

namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string input = Console.ReadLine();

            //ACTION
            int[] inputArray = input.Split().Select(int.Parse).ToArray();

            //Average Number Finder
            int numbersSum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                numbersSum += inputArray[i];
            }
            double averageNumber = (double)numbersSum / (double)inputArray.Length;

            //Top 5 Greater Numbers Than The Average
            int[] greaterNumbers = new int[inputArray.Length];
            int greaterNumbersCounter = 0;

            int k = 0;
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (inputArray[j] > averageNumber)
                {
                    greaterNumbers[k] = inputArray[j];
                    greaterNumbersCounter++;
                    k++;
                }

            }

            //Descending Order Output
            if (averageNumber >= 0)
            {
                int[] outputArray = new int[greaterNumbersCounter];
                for (int i = 0; i < greaterNumbersCounter; i++)
                {
                    outputArray[i] = greaterNumbers[i];
                }

                Array.Sort(outputArray);
                Array.Reverse(outputArray);

                if (greaterNumbersCounter >= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"{outputArray[i]} ");
                    }
                }
                else if (greaterNumbersCounter == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    for (int i = 0; i < greaterNumbersCounter; i++)
                    {
                        Console.Write($"{outputArray[i]} ");
                    }
                }
            }

            else
            {
                int[] outputArray = new int[greaterNumbersCounter];
                for (int i = 0; i < greaterNumbersCounter; i++)
                {
                    outputArray[i] = greaterNumbers[i];
                }
                Array.Sort(outputArray);

                if (greaterNumbersCounter >= 5)
                {
                    for (int i = 5; i > 0; i--)
                    {
                        greaterNumbersCounter--;
                        Console.Write($"{outputArray[greaterNumbersCounter]} ");
                    }
                }
                else if (greaterNumbersCounter == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    for (int i = greaterNumbersCounter -1; i >= 0; i--)
                    {
                        Console.Write($"{outputArray[i]} ");
                    }
                }
            }
        }
    }
}