
//INPUT
int chosenNumber = int.Parse(Console.ReadLine());
int multiplicationNumber = int.Parse(Console.ReadLine());

//ACTION
if (multiplicationNumber > 10)
{
    Console.WriteLine($"{chosenNumber} X {multiplicationNumber} = {chosenNumber * multiplicationNumber}");
}
else
{
    for (int i = multiplicationNumber; i <= 10; i++)
    {
        Console.WriteLine($"{chosenNumber} X {i} = {chosenNumber * i}");
    }
}

