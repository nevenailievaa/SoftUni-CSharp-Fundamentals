//INPUT
int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

//CHANGEABLE
double rageExpenses = 0;
int headsetTrashes = 0;
int mouseTrashes = 0;
int keyboardTrashes = 0;
int displayTrashes = 0;

//ACTION
//Trashes
for (int i = 1; i <= lostGames; i++)
{
    if (i % 2 == 0)
    {
        headsetTrashes++;
    }
    if (i % 3 == 0)
    {
        mouseTrashes++;
    }
    if (i % 2 == 0 && i % 3 == 0)
	{
		keyboardTrashes++;

        if (keyboardTrashes % 2 == 0)
        {
            displayTrashes++;
        }
    }
}

//OUTPUT
rageExpenses = headsetTrashes * headsetPrice + mouseTrashes * mousePrice + keyboardTrashes * keyboardPrice + displayTrashes * displayPrice;

Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");

