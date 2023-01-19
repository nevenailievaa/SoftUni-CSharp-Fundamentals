//INPUT
double britishPounds = double.Parse(Console.ReadLine());

//ACTION
double poundsToDollars = britishPounds * 1.31;

//OUTPUT
Console.WriteLine($"{poundsToDollars:f3}");
