//INPUT
int[] inputArray = (Console.ReadLine()).Split().Select(int.Parse).ToArray();

//CHANGEABLE
int leftSideSum = 0;
int rightSideSum = 0;

//ACTION
for (int i = 0; i < inputArray.Length; i++)
{
	//Sides sum
	for (int r = i; r < inputArray.Length; r++)
	{
		rightSideSum += inputArray[r];
	}
	for (int l = i; l >= 0; l--)
	{
		leftSideSum += inputArray[l];
	}

	//Comparing the sides
    if (leftSideSum == rightSideSum)
    {
        Console.WriteLine(i);
		return;
    }
	else
	{
		rightSideSum = 0;
		leftSideSum = 0;
	}
}

Console.WriteLine("no");
