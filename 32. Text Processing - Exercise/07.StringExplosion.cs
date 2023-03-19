using System;
using System.Text;

//INPUT
StringBuilder currentString = new StringBuilder();
currentString.Append(Console.ReadLine());

//ACTION
int power = 0;
for (int i = 0; i < currentString.Length; i++)
{
	if (power == 0)
	{
		if (currentString[i] == '>')
		{
			power += int.Parse(currentString[i+1].ToString());
		}
	}
	else
	{
		if (currentString[i] == '>')
		{
            power += int.Parse(currentString[i+1].ToString());
        }
		else
		{
			currentString.Remove(i, 1);
			i--;
            power--;
        }
	}
}

//OUTPUT
Console.WriteLine(currentString);

//Explosions are marked with '>'. Immediately after the mark,
//there will be an integer, which signifies the strength of the explosion.
