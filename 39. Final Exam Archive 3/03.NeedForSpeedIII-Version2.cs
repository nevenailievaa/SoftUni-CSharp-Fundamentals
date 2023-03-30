//INPUT
int carsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, int> carAndMileage = new Dictionary<string, int>();
Dictionary<string, int> carAndFuel = new Dictionary<string, int>();

for (int i = 0; i < carsCount; i++)
{
    string[] carInfo = Console.ReadLine().Split("|");
    string carName = carInfo[0];
    int mileage = int.Parse(carInfo[1]);
    int fuel = int.Parse(carInfo[2]);

    carAndMileage.Add(carName, mileage);
    carAndFuel.Add(carName, fuel);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "Stop")
{
    string[] commandArray = command.Split(" : ");
    string commandType = commandArray[0];

    //Drive Command
    if (commandType == "Drive")
    {
        string carName = commandArray[1];
        int distance = int.Parse(commandArray[2]);
        int fuel = int.Parse(commandArray[3]);

        if (carAndFuel[carName] - fuel >= 0)
        {
            carAndMileage[carName] += distance;
            carAndFuel[carName] -= fuel;
            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        if (carAndMileage[carName] >= 100000)
        {
            Console.WriteLine($"Time to sell the {carName}!");
            carAndMileage.Remove(carName);
            carAndFuel.Remove(carName);
        }
    }

    //Refuel Command
    else if (commandType == "Refuel")
    {
        string carName = commandArray[1];
        int fuel = int.Parse(commandArray[2]); //60 + 20 = 80    15

        int currentFuel = carAndFuel[carName];
        int addedFuel = 0;

        if (carAndFuel[carName] + fuel > 75)
        {
            carAndFuel[carName] = 75;
            addedFuel = 75 - currentFuel;
        }
        else
        {
            addedFuel = fuel;
            carAndFuel[carName] += fuel;
        }
        Console.WriteLine($"{carName} refueled with {addedFuel} liters");
    }

    //Revert Command
    else if (commandType == "Revert")
    {
        string carName = commandArray[1];
        int kilometers = int.Parse(commandArray[2]);

        if (carAndMileage[carName] - kilometers < 10000)
        {
            carAndMileage[carName] = 10000;
        }
        else
        {
            carAndMileage[carName] -= kilometers;
            Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
        }
    }
}

//OUTPUT
foreach (var car in carAndMileage)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carAndFuel[car.Key]} lt.");
}