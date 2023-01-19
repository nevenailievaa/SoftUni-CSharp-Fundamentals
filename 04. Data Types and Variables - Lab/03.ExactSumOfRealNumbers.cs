//INPUT
int numbersCount = int.Parse(Console.ReadLine());

//CHANGEABLE
decimal numbersSum = 0;

//ACTION
for (int i = 1; i <= numbersCount; i++)
{
    decimal inputNumber = decimal.Parse(Console.ReadLine());
    numbersSum += inputNumber;
}

//OUTPUT
Console.WriteLine($"{numbersSum}");
