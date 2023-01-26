//INPUT
int n = int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];

//ACTION
for (int i = 0; i < n; i++)
{
    int[] currentInput = (Console.ReadLine()).Split().Select(int.Parse).ToArray();
	if (i % 2 == 1)
	{
		firstArray[i] = currentInput[0];
		secondArray[i] = currentInput[1];
	}
	else
	{
        secondArray[i] = currentInput[0];
        firstArray[i] = currentInput[1];
    }
}
//OUTLINE
Console.WriteLine(string.Join(" ", secondArray));
Console.WriteLine(string.Join(" ", firstArray));
