//INPUT
int beerKegsCount = int.Parse(Console.ReadLine());

//CHANGEABLE
double biggestKegVolume = double.MinValue;
string biggestKeg = null;

//ACTIONS
for (int i = 1; i <= beerKegsCount; i++)
{
    string kegModel = Console.ReadLine();
    double kegRadius = double.Parse(Console.ReadLine());
    int kegHeight = int.Parse(Console.ReadLine());

    //Volume
    double volumeCurrentKeg = Math.PI * Math.Pow(kegRadius , 2) * kegHeight;

    if (volumeCurrentKeg > biggestKegVolume)
    {
        biggestKeg = kegModel;
        biggestKegVolume = volumeCurrentKeg;
    }
}

//OUTPUT
Console.WriteLine(biggestKeg);
