//INPUT
Console.Write("Length: "); double length = double.Parse(Console.ReadLine());

Console.Write("Width: "); double width = double.Parse(Console.ReadLine());

Console.Write("Height: "); double height = double.Parse(Console.ReadLine());

//BASE AREA
double baseArea = length * width;

//VOLUME
double volume = ((baseArea * height) / 3.0);

//OUTPUT
Console.WriteLine($"Pyramid Volume: {volume:f2}");