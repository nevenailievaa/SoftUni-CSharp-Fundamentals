//INPUT
int[] inputNumbers = (Console.ReadLine()).Split().Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());

//ACTION
for (int j = 0; j < rotations; j++)
{
    int firstElement = inputNumbers[0];

    for (int i = 0; i < inputNumbers.Length-1; i++)
    {
        inputNumbers[i] = inputNumbers[i+1];
    }

    inputNumbers[inputNumbers.Length-1] = firstElement;
}

//OUTPUT
Console.WriteLine(string.Join(" ", inputNumbers));

