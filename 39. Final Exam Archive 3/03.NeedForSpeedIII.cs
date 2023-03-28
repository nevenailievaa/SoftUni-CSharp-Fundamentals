//INPUT
int carsCount = int.Parse(Console.ReadLine());

//ACTION
List<Car> carsList = new List<Car>();

for (int i = 0; i < carsCount; i++)
{
    string[] carsInfo = Console.ReadLine().Split("|");
    string carName = carsInfo[0];
    int mileage = int.Parse(carsInfo[1]);
    int fuel = int.Parse(carsInfo[2]);

    Car currentCar = new Car(carName, mileage, fuel);
    carsList.Add(currentCar);
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

        for (int i = 0; i < carsList.Count; i++)
        {
            if (carsList[i].Name == carName)
            {
                if (carsList[i].Fuel >= fuel)
                {
                    carsList[i].Mileage += distance;
                    carsList[i].Fuel -= fuel;
                    Console.WriteLine($"{carsList[i].Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    if (carsList[i].Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carsList[i].Name}!");
                        carsList.Remove(carsList[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Not enough fuel to make that ride");
                }
            }
        }
    }

    //Refuel Command
    else if (commandType == "Refuel")
    {
        string carName = commandArray[1];
        int fuel = int.Parse(commandArray[2]);

        for (int i = 0; i < carsList.Count; i++)
        {
            if (carsList[i].Name == carName)
            {
                int currentFuel = carsList[i].Fuel;
                if (currentFuel + fuel > 75)
                {
                    int additionalFuel = 75 - currentFuel;
                    carsList[i].Fuel += additionalFuel;
                    Console.WriteLine($"{carsList[i].Name} refueled with {additionalFuel} liters");
                }
                else
                {
                    carsList[i].Fuel += fuel;
                    Console.WriteLine($"{carsList[i].Name} refueled with {fuel} liters");
                }
            }
        }
    }

    //Revert Command
    else if (commandType == "Revert")
    {
        string carName = commandArray[1];
        int kilometers = int.Parse(commandArray[2]); //25000 - 20000   10000

        for (int i = 0; i < carsList.Count; i++)
        {
            if (carsList[i].Name == carName)
            {
                int currentMileage = carsList[i].Mileage;
                int remainingMileage = currentMileage - kilometers;

                if (remainingMileage < 10000)
                {
                    carsList[i].Mileage = 10000;
                }
                else
                {
                    carsList[i].Mileage -= kilometers;
                    Console.WriteLine($"{carsList[i].Name} mileage decreased by {currentMileage - remainingMileage} kilometers");
                }
            }
        }
    }
}

//OUTPUT
foreach (Car car in carsList)
{
    Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
}

//Class Car
public class Car
{
    public string Name { get; set; }
    public int Mileage { get; set; }
    public int Fuel { get; set; }

    public Car (string name, int mileage, int fuel)
    {
        Name = name;
        Mileage = mileage;
        Fuel = fuel;
    }
}