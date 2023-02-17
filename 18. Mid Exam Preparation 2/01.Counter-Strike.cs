//INPUT
int energy = int.Parse(Console.ReadLine());
int wonBattles = 0;
string command = string.Empty;

//ACTION
while ((command = Console.ReadLine()) != "End of battle")
{
    int distance = int.Parse(command);

    if (distance <= energy)
    {
        wonBattles++;
        energy -= distance;

        if (wonBattles % 3 == 0)
        {
            energy += wonBattles;
        }
    }
    else
    {
        Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
        return;
    }
}

//OUTPUT
Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");