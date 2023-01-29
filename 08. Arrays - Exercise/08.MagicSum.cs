//INPUT
int[] inputArray = (Console.ReadLine()).Split().Select(int.Parse).ToArray();
int givenNumber = int.Parse(Console.ReadLine());

//ACTION
for (int i = 0; i < inputArray.Length; i++)
{
	for (int j = i + 1; j < inputArray.Length; j++)
	{
		if (inputArray[i] + inputArray[j] == givenNumber)
		{
			//OUTPUT
			Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
		}
	}
}