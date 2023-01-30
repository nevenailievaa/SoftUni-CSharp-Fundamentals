//INPUT
int dnasLength = int.Parse(Console.ReadLine());

//CHANGEABLE
string command;
int[] inputArray = new int[dnasLength];
int[] outputArray = new int[dnasLength];

//COMPARING DATA
//Ones Sequences
int biggestSequenceOfOnes = 0;
int currentSequenceOfOnes = 0;
//Indexes
int bestStartingIndex = int.MaxValue;
int currentStartingIndex = int.MaxValue;
//DNA Samples Counter
int dnaSamplesCount = 0;
int dnaCurrentCount = 0;
//Ones Sum
int onesBestSum = 0;
int onesCurrentSum = 0;

//ACTION
while ((command = Console.ReadLine()) != "Clone them!")
{
    inputArray = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	dnaSamplesCount++;

	for (int i = 0; i < dnasLength; i++)
	{
		currentSequenceOfOnes = 0;
		currentStartingIndex = int.MaxValue;
		onesCurrentSum = 0;
		//Sum Cycle
		for (int s = 0; s < dnasLength; s++)
		{
			if (inputArray[s] == 1)
			{
				onesCurrentSum++;
			}
		}
		
		for (int j = i; j < dnasLength; j++)
		{
			//Ones Sequences
			if (inputArray[j] == 1)
			{
				currentSequenceOfOnes++;

				if (currentSequenceOfOnes > biggestSequenceOfOnes)
				{
                    currentStartingIndex = i;
                    biggestSequenceOfOnes = currentSequenceOfOnes;
					outputArray = inputArray;
					bestStartingIndex = int.MaxValue;
                    dnaCurrentCount = dnaSamplesCount;

                    //Starting Index
                    if (currentStartingIndex < bestStartingIndex)
					{
						bestStartingIndex = currentStartingIndex;
						onesCurrentSum = onesBestSum;
					}
				}
				//Ones Sum
				if (onesCurrentSum > onesBestSum)
				{
					onesBestSum = onesCurrentSum;
				}
            }
            else if (inputArray[j] == 0)
            {
                break;
            }
            //Leftmost Starting index
            if (currentSequenceOfOnes == biggestSequenceOfOnes)
            {
				currentStartingIndex = i;
                if (currentStartingIndex < bestStartingIndex)
                {
                    outputArray = inputArray;
                    dnaCurrentCount = dnaSamplesCount;
                }
				//Sum
				else if (currentStartingIndex == bestStartingIndex)
                {
					if (onesCurrentSum > onesBestSum)
					{
						onesBestSum = onesCurrentSum;
                        outputArray = inputArray;
                        dnaCurrentCount = dnaSamplesCount;
                    }
				}
            }
		}
	}
}

//OUTPUT
Console.WriteLine($"Best DNA sample {dnaCurrentCount} with sum: {onesBestSum}.");
for (int k = 0; k < dnasLength; k++)
{
	Console.Write($"{outputArray[k]} ");
}