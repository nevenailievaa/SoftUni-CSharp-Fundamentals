//INPUT
int inputNumber = int.Parse(Console.ReadLine());

//CHANGEABLE
int digitsSum = 0;

//ACTION
for (int i = 1; i <= inputNumber; i++)
{
    int currentNumber = i;

    while (currentNumber > 0)
    {
        int lastDigit = currentNumber % 10;
        currentNumber = (currentNumber - lastDigit) / 10;
        digitsSum += lastDigit;
    }

    //OUTPUT
    if (digitsSum == 5 || digitsSum == 7 || digitsSum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
    digitsSum = 0;
}