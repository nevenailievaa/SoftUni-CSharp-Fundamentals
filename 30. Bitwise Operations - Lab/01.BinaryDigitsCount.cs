//INPUT
using System;

int number = int.Parse(Console.ReadLine());
int binaryDigit = int.Parse(Console.ReadLine());

//ACTION
List<int> numberInBynarySystem = new List<int>();
int binaryDigitCounter = 0;

while (number != 0)
{
    numberInBynarySystem.Add(number % 2);
    if (number % 2 == binaryDigit)
    {
        binaryDigitCounter++;

    }
    number /= 2;
}

//OUTPUT
Console.WriteLine(binaryDigitCounter);