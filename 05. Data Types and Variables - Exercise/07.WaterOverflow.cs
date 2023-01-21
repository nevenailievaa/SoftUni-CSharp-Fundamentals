//INPUT
short poursCount = short.Parse(Console.ReadLine());

//CHANGEABLE
short poursSum = 0;

//ACTION
byte waterTankCapacity = byte.MaxValue;

for (int i = 1; i <= poursCount; i++)
{
    short currentPour = short.Parse(Console.ReadLine());
    poursSum += currentPour;

    if (poursSum > waterTankCapacity)
    {
        Console.WriteLine("Insufficient capacity!");
        poursSum -= currentPour;
    }
}

//OUTPUT
Console.WriteLine(poursSum);
