//INPUT
int inputNumber = int.Parse(Console.ReadLine());
int inputNumberLength = inputNumber.ToString().Length;
int digitsSum = 0;
int currentNumber = inputNumber;

//ACTION
for (int i = 1; i <= inputNumberLength; i++)
{
    int lastDigit = currentNumber % 10;
    digitsSum += lastDigit;
    currentNumber = currentNumber / 10;
}

//OUTPUT
Console.WriteLine(digitsSum);