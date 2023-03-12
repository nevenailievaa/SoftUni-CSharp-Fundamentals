//INPUT
string[] stringInput = Console.ReadLine().Split();

//ACTION
for (int i = 0; i < stringInput.Length; i++)
{
	for (int j = 0; j < stringInput[i].Length; j++)
	{
        //OUTPUT
        Console.Write(stringInput[i]);
    }
}