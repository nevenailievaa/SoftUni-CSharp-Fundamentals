//INPUT
string info = string.Empty;
List<Car> carsList = new List<Car>();
List<Truck> trucksList = new List<Truck>();

//ACTION
while ((info = Console.ReadLine()) != "end")
{
    string[] infoArray = info.Split("/");
    string typeVehicle = infoArray[0];
    string brandVehicle = infoArray[1];
    string modelVehicle = infoArray[2];

    //Car Case
    if (typeVehicle == "Car")
    {
        int horsePowerVehicle = int.Parse(infoArray[3]);

        Car currentCar = new Car()
        {
            Brand = brandVehicle,
            Model = modelVehicle,
            HorsePower = horsePowerVehicle
        };
        
        carsList.Add(currentCar);
    }

    //Truck Case
    else if (typeVehicle == "Truck")
    {
        int weightVehicle = int.Parse(infoArray[3]);

        int horsePowerVehicle = int.Parse(infoArray[3]);

        Truck currentTruck = new Truck()
        {
            Brand = brandVehicle,
            Model = modelVehicle,
            Weight = weightVehicle
        };

        trucksList.Add(currentTruck);
    }
}

//OUTPUT
//Cars
if (carsList.Count > 0)
{
    Console.WriteLine("Cars:");
    foreach (Car car in carsList.OrderBy(x => x.Brand))
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

//Trucks
if (trucksList.Count > 0)
{

    Console.WriteLine("Trucks:");
    foreach (Truck truck in trucksList.OrderBy(x => x.Brand))
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}

//Truck Class
public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
};

//Car Class
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
};