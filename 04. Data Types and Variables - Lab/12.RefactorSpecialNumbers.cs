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

    if (digitsSum == 5 || digitsSum == 7 || digitsSum == 11)
    {
        //OUTPUT
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        //OUTPUT
        Console.WriteLine($"{i} -> False");
    }
    
    //Restore Data
    digitsSum = 0;
}
