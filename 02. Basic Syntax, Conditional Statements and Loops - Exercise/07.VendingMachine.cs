//INPUT
string input = Console.ReadLine();

//PRICES
double nuts = 2.0;
double water = 0.7;
double crisps = 1.5;
double soda = 0.8;
double coke = 1.0;

//CHANGEABLE
double coin = 0;
double coinsSum = 0;

//ACTION
//Coins
while (input != "Start")
{
    coin = (double.Parse(input));

    if (coin == 0.1)
    {
        coinsSum += coin;
    }
    else if (coin == 0.2)
    {
        coinsSum += coin;
    }
    else if (coin == 0.5)
    {
        coinsSum += coin;
    }
    else if (coin == 1.00)
    {
        coinsSum += coin;
    }
    else if (coin == 2.00)
    {
        coinsSum += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }

    input = Console.ReadLine();
}

//Products
string product = null;

while ((product = Console.ReadLine()) != "End")
{
    if (product == "Nuts")
    {
        coinsSum -= nuts;
        if (coinsSum < 0)
        {
            Console.WriteLine("Sorry, not enough money");
            coinsSum += nuts;
        }
        else
        {
            Console.WriteLine("Purchased nuts");
        }
    }
    else if (product == "Water")
    {
        coinsSum -= water;
        if (coinsSum < 0)
        {
            Console.WriteLine("Sorry, not enough money");
            coinsSum += water;
        }
        else
        {
            Console.WriteLine("Purchased water");
        }
    }
    else if (product == "Crisps")
    {
        coinsSum -= crisps;
        if (coinsSum < 0)
        {
            Console.WriteLine("Sorry, not enough money");
            coinsSum += crisps;
        }
        else
        {
            Console.WriteLine("Purchased crisps");
        }
    }
    else if (product == "Soda")
    {
        coinsSum -= soda;
        if (coinsSum < 0)
        {
            Console.WriteLine("Sorry, not enough money");
            coinsSum += soda;
        }
        else
        {
            Console.WriteLine("Purchased soda");
        }
    }
    else if (product == "Coke")
    {
        coinsSum -= coke;
        if (coinsSum < 0)
        {
            Console.WriteLine("Sorry, not enough money");
            coinsSum += coke;
        }
        else
        {
            Console.WriteLine("Purchased coke");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}

//OUTPUT
Console.WriteLine($"Change: {coinsSum:f2}");