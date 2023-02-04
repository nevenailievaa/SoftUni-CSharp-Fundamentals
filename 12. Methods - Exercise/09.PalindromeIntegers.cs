using System;
public class Program
{
    static void Main()
    {
        //INPUT
        string input = Console.ReadLine();

        //OUTPUT
        PalindromeChecker(input);
    }

    //ACTION
    static void PalindromeChecker(string inputCommand)
    {
        while (inputCommand != "END")
        {
            char[] numberArray = inputCommand.ToCharArray();

            //If Number's Length Is One
            if (inputCommand.Length == 1)
            {
                Console.WriteLine("true");
            }

            //If Number's Length Is Even
            else if (inputCommand.Length % 2 == 0)
            {
                int[] numbersFirstHalf = new int[inputCommand.Length / 2];
                int[] numbersSecondHalf = new int[inputCommand.Length / 2];

                //First Half
                for (int i = 0; i <= inputCommand.Length / 2 - 1; i++)
                {
                    numbersFirstHalf[i] = numberArray[i];
                }
                //SecondHalf
                for (int j = inputCommand.Length / 2 - 1; j >= 0; j--)
                {
                    numbersSecondHalf[j] = numberArray[inputCommand.Length - 1 - j];
                }

                //Comparing
                bool isEqual = false;

                for (int k = 0; k < numbersFirstHalf.Length; k++)
                {
                    if (numbersFirstHalf[k] == numbersSecondHalf[k])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }

                //OUTPUT
                if (isEqual)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

            //If Number's Length Is Odd
            else
            {
                int[] numbersFirstHalf = new int[inputCommand.Length / 2];
                int[] numbersSecondHalf = new int[inputCommand.Length / 2];

                //First Half
                for (int i = 0; i < inputCommand.Length / 2; i++)
                {
                    numbersFirstHalf[i] = numberArray[i];
                }
                //SecondHalf
                for (int j = 0; j < inputCommand.Length / 2; j++)
                {
                    numbersSecondHalf[j] = numberArray[inputCommand.Length - 1 - j];
                }

                //Comparing
                bool isEqual = false;

                for (int k = 0; k < numbersFirstHalf.Length; k++)
                {
                    if (numbersFirstHalf[k] == numbersSecondHalf[k])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }
                //OUTPUT
                if (isEqual)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            //INPUT
            inputCommand = Console.ReadLine();
        }
        return;
    }
}