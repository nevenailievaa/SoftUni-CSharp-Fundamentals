//INPUT
string command = Console.ReadLine();
double totalPriceWithoutTaxes = 0;
double totalPriceWithTaxes = 0;
double taxes = 0;

//ACTION
while (command != "special" && command != "regular")
{
    double currentPrice = double.Parse(command);

    if (currentPrice <= 0)
	{
		Console.WriteLine("Invalid price!");
	}
	else
	{
		totalPriceWithoutTaxes += currentPrice;
		totalPriceWithTaxes += (currentPrice * 0.2) + currentPrice;
		taxes += (currentPrice * 0.2);
    }

	command = Console.ReadLine();
}

if (command == "special")
{
	totalPriceWithTaxes *= 0.9;

	if (totalPriceWithTaxes <= 0)
	{
		Console.WriteLine("Invalid order!");
		return;
	}
}
else if (command == "regular")
{
    if (totalPriceWithTaxes <= 0)
    {
        Console.WriteLine("Invalid order!");
        return;
    }
}

//OUTPUT
Console.WriteLine("Congratulations you've just bought a new computer!");
Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
Console.WriteLine($"Taxes: {taxes:f2}$");
Console.WriteLine("-----------");
Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");