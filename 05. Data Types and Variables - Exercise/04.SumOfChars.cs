//INPUT
int numberCharacters = int.Parse(Console.ReadLine());

//CHANGEABLE
int charsSum = 0;

//ACTION
for (int i = 1; i <= numberCharacters; i++)
{
    char charInput = char.Parse(Console.ReadLine());
    charsSum += charInput;
}

//OUTPUT
Console.WriteLine($"The sum equals: {charsSum}");