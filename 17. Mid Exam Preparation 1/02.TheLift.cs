//INPUT
int peopleWaitingForTheLift = int.Parse(Console.ReadLine());
int[] liftArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

//ACTION
for (int i = 0; i < liftArray.Length; i++)
{
	if (peopleWaitingForTheLift == 0)
	{
		break;
	}
    while (liftArray[i] < 4 && liftArray[i] >= 0)
    {
        if (peopleWaitingForTheLift == 0)
        {
            break;
        }
		else
		{
            peopleWaitingForTheLift--;
            liftArray[i]++;
        }
    }
}

//Empty Spots Checker
bool emptySpots = false;
for (int j = 0; j < liftArray.Length; j++)
{
	if (liftArray[j] < 4 && liftArray[j] >= 0)
	{
		emptySpots = true;
		break;
	}
}

//OUTPUT
if (peopleWaitingForTheLift == 0 || emptySpots == false)
{
	if (peopleWaitingForTheLift == 0 && emptySpots == true)
	{
		Console.WriteLine("The lift has empty spots!");
		Console.WriteLine(String.Join(' ', liftArray));
    }
	else if (peopleWaitingForTheLift > 0 && emptySpots == false)
	{
		Console.WriteLine($"There isn't enough space! {peopleWaitingForTheLift} people in a queue!");
		Console.WriteLine(String.Join(' ', liftArray));
	}
	else if (peopleWaitingForTheLift == 0 && emptySpots == false)
	{
        Console.WriteLine(String.Join(' ', liftArray));
    }
}