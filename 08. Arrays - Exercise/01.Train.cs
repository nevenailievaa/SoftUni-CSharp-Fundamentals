//INPUT
int numberWagons = int.Parse(Console.ReadLine());

//CHANGEABLE DATA
int allPassengersSum = 0;

//ACTION
int[] peopleOnTheWagon = new int[numberWagons];

for (int i = 0; i < numberWagons; i++)
{
    peopleOnTheWagon[i] = int.Parse(Console.ReadLine());
    allPassengersSum += peopleOnTheWagon[i];
}

//OUTPUT
for (int i = 0; i < numberWagons; i++)
{
    Console.Write($"{peopleOnTheWagon[i]} ");
}
Console.WriteLine();
Console.WriteLine(allPassengersSum);