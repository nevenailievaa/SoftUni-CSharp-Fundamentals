using System;
public class Program
{
    static void Main()
    {
        //INPUT
        int inputNumber = int.Parse(Console.ReadLine());

        //OUTPUT
        TopNumbers(inputNumber);
    }

    //ACTION
    static void TopNumbers(int endNumber)
    {
        for (int i = 1; i <= endNumber; i++)
        {
            bool digitsSumDivisibleByEight = false;
            bool atLeastOneOddDigit = false;

            string iString = Convert.ToString(i);   
            char[] currentNumber = new char[iString.Length];

            int digitsSum = 0;
            for (int j = 0; j < iString.Length; j++)
            {
                //Sum Calculate
                currentNumber[j] = iString[j];
                digitsSum += currentNumber[j];

                //At Least One Odd Digit Checker
                if (currentNumber[j] % 2 == 1)
                {
                    atLeastOneOddDigit = true;
                }
            }

            //Sum Divisible By Eight Checker
            if (digitsSum % 8 == 0)
            {
                digitsSumDivisibleByEight = true;
            }

            //Final Checker
            if (digitsSumDivisibleByEight == true && atLeastOneOddDigit == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}