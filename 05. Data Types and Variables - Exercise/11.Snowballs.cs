using System.Numerics;

//INPUT
int snowballsCnt = int.Parse(Console.ReadLine());

//CHANGEABLE
BigInteger maxValue = 0;
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;

//ACTION
for (int i = 1; i <= snowballsCnt; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    BigInteger value = BigInteger.Pow(snow / time , quality);

    if (value > maxValue)
    {
        maxValue = value;
        bestSnow = snow;
        bestTime = time;
        bestQuality = quality;
    }
}

//OUTPUT
Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuality})");
