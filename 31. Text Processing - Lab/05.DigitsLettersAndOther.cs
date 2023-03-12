//INPUT
using System.Text;

string inputString = Console.ReadLine();

//ACTION
StringBuilder digits = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder symbols = new StringBuilder();

for (int i = 0; i < inputString.Length; i++)
{
	if (Char.IsDigit(inputString[i]))
	{
		digits.Append(inputString[i]);

    }
	else if (Char.IsLetter(inputString[i]))
	{
		letters.Append(inputString[i]);
    }
	else
	{
		symbols.Append(inputString[i]);
	}
}

//OUTPUT
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(symbols);