//INPUT
short linesCount = short.Parse(Console.ReadLine());

//ACTION
for (int i = 1; i <= linesCount; i++)
{
    string input = Console.ReadLine();
    var result = input.Split(" ");

    long firstNumber = long.Parse(result[0]);
    long secondNumber = long.Parse(result[1]);

    //Comparing
    if (firstNumber > secondNumber)
    {
        int firstNumberDigitsSum = 0;
        int firstNumberLength = result[0].Length;
        for (int j = 1; j <= firstNumberLength; j++)
        {
            long lastDigitFirstNum = firstNumber % 10;
            firstNumberDigitsSum += (int)lastDigitFirstNum;
            firstNumber /= 10;
        }
        Console.WriteLine(firstNumberDigitsSum);
    }
    else
    {
        int secondNumberDigitsSum = 0;
        int secondNumberLength = result[1].Length;
        for (int k = 1; k <= secondNumberLength; k++)
        {
            long lastDigitSecondNum = secondNumber % 10;
            secondNumberDigitsSum += (int)lastDigitSecondNum;
            secondNumber /= 10;
        }
        Console.WriteLine(secondNumberDigitsSum);
    }
}

// 25/100 Judge