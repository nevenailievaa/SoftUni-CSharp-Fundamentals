//INPUT
double currentBalance = double.Parse(Console.ReadLine());
string command = null;
string currentGame = null;
double spentMoney = 0;

//Game Prices
double OutFall4Price = 39.99;
double csPrice = 15.99;
double zplinterZellPrice = 19.99;
double honored2Price = 59.99;
double roverWatchPrice = 29.99;
double roverWatchOriginsEditionPrice = 39.99;

while ((command = Console.ReadLine()) != "Game Time")
{
    currentGame = command;

	//OutFall4
	if (currentGame == "OutFall 4")
	{
        if (currentBalance > 0 && currentBalance >= OutFall4Price)
        {
            currentBalance -= OutFall4Price;
            spentMoney += OutFall4Price;
            Console.WriteLine($"Bought {currentGame}");

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
		else if (currentBalance < OutFall4Price)
		{
			Console.WriteLine("Too Expensive");
		}
	}
    //CS:GO
    else if (currentGame == "CS: OG")
    {
        if (currentBalance > 0 && currentBalance >= csPrice)
        {
            currentBalance -= csPrice;
            spentMoney += csPrice;
            Console.WriteLine($"Bought {currentGame}");

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
        else if (currentBalance < csPrice)
        {
            Console.WriteLine("Too Expensive");
        }
    }
    //Zplinter Zell
    else if (currentGame == "Zplinter Zell")
    {
        if (currentBalance > 0 && currentBalance >= zplinterZellPrice)
        {
            currentBalance -= zplinterZellPrice;
            spentMoney += zplinterZellPrice;
            Console.WriteLine($"Bought {currentGame}");

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
        else if (currentBalance < zplinterZellPrice)
        {
            Console.WriteLine("Too Expensive");
        }
    }
    //Honored 2
    else if (currentGame == "Honored 2")
    {
        if (currentBalance > 0 && currentBalance >= honored2Price)
        {
            currentBalance -= honored2Price;
            spentMoney += honored2Price;
            Console.WriteLine($"Bought {currentGame}");

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
        else if (currentBalance < honored2Price)
        {
            Console.WriteLine("Too Expensive");
        }
    }
    //RoverWatch
    else if (currentGame == "RoverWatch")
    {
        if (currentBalance > 0 && currentBalance >= roverWatchPrice)
        {
            currentBalance -= roverWatchPrice;
            spentMoney += roverWatchPrice;
            Console.WriteLine($"Bought {currentGame}");

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
        else if (currentBalance < roverWatchPrice)
        {
            Console.WriteLine("Too Expensive");
        }
    }
    //RoverWatch Origins Edition
    else if (currentGame == "RoverWatch Origins Edition")
    {
        if (currentBalance > 0 && currentBalance >= roverWatchOriginsEditionPrice)
        {
            currentBalance -= roverWatchOriginsEditionPrice;
            spentMoney += roverWatchOriginsEditionPrice;
            Console.WriteLine($"Bought {currentGame}");

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }
        else if (currentBalance < roverWatchOriginsEditionPrice)
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else
	{
		Console.WriteLine("Not Found");
	}
}

//OUTPUT
Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");
