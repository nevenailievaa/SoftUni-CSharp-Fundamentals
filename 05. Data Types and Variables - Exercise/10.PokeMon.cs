//INPUT
int pwr = int.Parse(Console.ReadLine()); 
int trgt = int.Parse(Console.ReadLine());
int exhaust = int.Parse(Console.ReadLine()); 

//CHANGEABLE
int pokeCnt = 0;
int startPwr = pwr;

//ACTION
while (pwr >= trgt)
{
    pokeCnt++;
    pwr -= trgt;

    if (pwr != 0 && startPwr != 0 && exhaust != 0)
    {
        if (startPwr / (double)pwr == 2)
        {
            pwr /= exhaust;
        }
    }
}

//OUTPUT
Console.WriteLine(pwr);
Console.WriteLine(pokeCnt);