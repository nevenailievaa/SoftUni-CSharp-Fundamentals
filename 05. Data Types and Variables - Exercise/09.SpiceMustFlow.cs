//INPUT
uint firstDayYield = uint.Parse(Console.ReadLine());

//CHANGEABLE
uint currentDayYield = firstDayYield;
uint daysCount = 0;
uint workersConsumationSum = 0;

//ACTION
while (currentDayYield >= 100)
{
    daysCount++;
    workersConsumationSum += (currentDayYield - 26u);
    currentDayYield -= 10u;
}

if (daysCount > 0)
{
    workersConsumationSum -= 26u;
}

//OUTPUT
Console.WriteLine(daysCount);
Console.WriteLine(workersConsumationSum);
