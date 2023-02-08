
using System;
using System.Linq;

namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string input = Console.ReadLine();
            int[] inputArray = input.Split().Select(int.Parse).ToArray();
            string command = string.Empty;

            //Array Copy
            int[] inputArrayCopy = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArrayCopy[i] = inputArray[i];
            }

            //OUTPUT
            Modifier(inputArray, inputArrayCopy, command);


            //ACTION
            static void Modifier(int[] inputArray, int[] inputArrayCopy, string command)
            {
                int[] outputArray = inputArray;


                while ((command = Console.ReadLine()) != "end")
                {
                    //SWAP
                    if (command.Contains("swap") == true)
                    {
                        string[] commandNumbers = command.Split();
                        int[] numbers = new int[2];

                        numbers[0] = int.Parse(commandNumbers[1]);
                        numbers[1] = int.Parse(commandNumbers[2]);

                        outputArray[numbers[0]] = inputArrayCopy[numbers[1]];
                        outputArray[numbers[1]] = inputArrayCopy[numbers[0]];
                    }

                    //MULTIPLY
                    else if (command.Contains("multiply") == true)
                    {
                        string[] commandNumbers = command.Split();
                        int[] numbers = new int[2];

                        numbers[0] = int.Parse(commandNumbers[1]);
                        numbers[1] = int.Parse(commandNumbers[2]);

                        outputArray[numbers[0]] *= inputArray[numbers[1]];
                    }

                    //DECREASE
                    else if (command.Contains("decrease") == true)
                    {
                        for (int i = 0; i < outputArray.Length; i++)
                        {
                            outputArray[i] -= 1;
                        }
                    }

                    //RESTORE
                    for (int j = 0; j < outputArray.Length; j++)
                    {
                        inputArrayCopy[j] = outputArray[j];
                    }
                }

                //OUTPUT
                Console.WriteLine(String.Join(", ", outputArray));
            }
        }
    }
}

