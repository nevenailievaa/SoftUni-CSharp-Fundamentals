//INPUT
int[] inputArray = (Console.ReadLine()).Split().Select(int.Parse).ToArray();

//CHANGEABLE
bool isTop = false;
int[] outputArray = new int[inputArray.Length];
int outputArrayIndex = 0;
int topNumbersCnt = 0;


//ACTION
for (int i = 0; i < inputArray.Length; i++)
{
	for (int j = i+1; j < inputArray.Length; j++)
	{
		if (inputArray[i] > inputArray[j])
		{
			isTop = true;
		}
		else
		{
			isTop = false;
			break;
		}
    }

    if (isTop == true || i == inputArray.Length - 1)
    {
        topNumbersCnt++;
        outputArray[outputArrayIndex] = inputArray[i];
        outputArrayIndex++;
    }
}

//OUTPUT
for (int k = 0; k < topNumbersCnt; k++)
{
	Console.Write(outputArray[k] + " ");
}

