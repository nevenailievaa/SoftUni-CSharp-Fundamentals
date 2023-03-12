//INPUT
string firstString = Console.ReadLine();
string secondString = Console.ReadLine();

//ACTION
while (secondString.Contains(firstString))
{
    int indexOfFirstString = secondString.IndexOf(firstString);
    secondString = secondString.Remove(indexOfFirstString, firstString.Length);
}

//OUTPUT
Console.WriteLine(secondString);