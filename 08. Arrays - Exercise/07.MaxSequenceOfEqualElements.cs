//INPUT
int[] inputArray = (Console.ReadLine()).Split().Select(int.Parse).ToArray();

//CHANGEABLE
int currentEqualElementsCount = 0;
int equalElementsCount = 0;
int currentIndexElement = 0;

//ACTION
for (int i = 0; i < inputArray.Length; i++)
{
	//Restore
    currentEqualElementsCount = 0;

	//Checker
    for (int j = i; j < inputArray.Length; j++)
	{
		if (inputArray[i] == inputArray[j])
		{
            currentEqualElementsCount++;

			if (currentEqualElementsCount > equalElementsCount)
			{
				equalElementsCount = currentEqualElementsCount;
				currentIndexElement = inputArray[i];
            }
        }
        else
		{
            break;
		}
	}
}

//OUTPUT
for (int i = 1; i <= equalElementsCount; i++)
{
    Console.Write($"{currentIndexElement} ");
}
