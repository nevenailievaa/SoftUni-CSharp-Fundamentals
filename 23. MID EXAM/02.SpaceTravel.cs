//INPUT
string[] travelRoute = Console.ReadLine().Split("||").ToArray();
int fuelAmount = int.Parse(Console.ReadLine());
int ammunitionAmount = int.Parse(Console.ReadLine());

//ACTION
for (int i = 0; i < travelRoute.Length; i++)
{
    string[] currentCommand = travelRoute[i].Split().ToArray();

    //Commands Checker
    //Travel Command
    if (currentCommand[0] == "Travel")
    {
        int lightYears = int.Parse(currentCommand[1]);
        fuelAmount -= lightYears;

        //Fuel Checker
        if (fuelAmount >= 0)
        {
            Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
        }
        else
        {
            Console.WriteLine("Mission failed.");
            return;
        }
    }

    //Enemy Command
    else if (currentCommand[0] == "Enemy")
    {
        int enemyArmor = int.Parse(currentCommand[1]);

        //Ammo Checker
        if (ammunitionAmount >= enemyArmor)
        {
            ammunitionAmount -= enemyArmor;
            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
        }
        else
        {
            fuelAmount -= enemyArmor * 2;

            //Run Away Check
            if (fuelAmount >= 0)
            {
                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
            }
            else
            {
                Console.WriteLine("Mission failed.");
                return;
            }
        }
    }

    //Repair Command
    else if (currentCommand[0] == "Repair")
    {
        int ammoAndFuelAdd = int.Parse(currentCommand[1]);
        fuelAmount += ammoAndFuelAdd;
        ammunitionAmount += ammoAndFuelAdd * 2;

        Console.WriteLine($"Ammunitions added: {ammoAndFuelAdd * 2}.");
        Console.WriteLine($"Fuel added: {ammoAndFuelAdd}.");
    }

    //Titan Command
    else if (currentCommand[0] == "Titan")
    {
        //OUTPUT
        Console.WriteLine("You have reached Titan, all passengers are safe.");
        return;
    }
}