//INPUT
int n = int.Parse(Console.ReadLine());

//ACTION
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		for (int k = 0; k < n; k++)
		{
			char firstChar = (char)('a' + i);
			char secondChar = (char)('a' + j);
			char thirdChar = (char)('a' + k);
            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
		}
	}
}
