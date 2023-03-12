//INPUT
string inputString = string.Empty;

//ACTION
List<string> stringsReversed = new List<string>();

while ((inputString = Console.ReadLine()) != "end")
{
	string reversedString = string.Empty;
	for (int i = inputString.Length -1; i >= 0; i--)
	{
		reversedString += inputString[i].ToString();
	}
	stringsReversed.Add($"{inputString} = {reversedString}");
}


//OUTPUT
for(int i = 0; i < stringsReversed.Count; i++)
{
    Console.WriteLine(stringsReversed[i]);
}