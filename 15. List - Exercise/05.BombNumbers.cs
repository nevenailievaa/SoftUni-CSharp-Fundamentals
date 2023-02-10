//INPUT
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string[] bombAndPower = Console.ReadLine().Split();

//ACTION
int bomb = Convert.ToInt32(bombAndPower[0].ToString());
int power = Convert.ToInt32(bombAndPower[1].ToString());

//Bomb Finder
int bombIndex;
int bombsCount = 0;

for (int i = 0; i < numbers.Count; i++)
{
	if (numbers[i] == bomb)
	{
		//Left Side
		for (int j = i; j >= i - power; j--)
		{
			if (j < 0)
			{
				break;
			}
			else
			{
				numbers.RemoveAt(j);
			}
		}
        //Right Side
        for (int k = i-power; k < i; k++)
        {
            if (k >= numbers.Count)
            {
                break;
            }
            else
            {
                numbers.RemoveAt(k);
            }
        }
    }
}

//Remaining Numbers Sum
int numsSum = 0;
for (int s = 0; s < numbers.Count; s++)
{
	numsSum += numbers[s];
}

//OUTPUT
Console.WriteLine(numsSum);