//INPUT
int[] arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

//CHANGEABLE
int sumEvenNumbers = 0;
int sumOddNumbers = 0;

//ACTION
for (int i = 0; i < arrayNumbers.Length; i++)
{
    if (arrayNumbers[i] % 2 == 0)
    {
        sumEvenNumbers += arrayNumbers[i];
    }
    else
    {
        sumOddNumbers += arrayNumbers[i];
    }
}

//OUTPUT
Console.WriteLine(sumEvenNumbers - sumOddNumbers);