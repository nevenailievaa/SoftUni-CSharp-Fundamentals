//INPUT
int days = int.Parse(Console.ReadLine());
int dailyPlunder = int.Parse(Console.ReadLine());
double expectedPlunder = double.Parse(Console.ReadLine());

//ACTION
double allPlunder = 0;
for (int i = 1; i <= days; i++)
{
    allPlunder += dailyPlunder;

	if (i % 3 == 0)
	{
        allPlunder += (double)dailyPlunder / 2;
    }
	if (i % 5 == 0)
	{
		allPlunder *= 0.7;
	}
}

//OUTPUT
if (allPlunder >= expectedPlunder)
{
	Console.WriteLine($"Ahoy! {allPlunder:f2} plunder gained.");
}
else
{
	double collectedPercentage = (allPlunder / expectedPlunder) * 100;
	Console.WriteLine($"Collected only {collectedPercentage:f2}% of the plunder.");
}