//INPUT
int chosenNumber = int.Parse(Console.ReadLine());

//CHANGEABLE
int multiplicationNumber = 0;

//ACTION
for (int i = 1; i <= 10; i++)
{
    multiplicationNumber = i;
    Console.WriteLine($"{chosenNumber} X {multiplicationNumber} = {chosenNumber * multiplicationNumber}");
}

