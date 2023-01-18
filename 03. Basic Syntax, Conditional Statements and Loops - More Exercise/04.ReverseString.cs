//INPUT

string username = Console.ReadLine();

//Reverse
char[] cArray = username.ToCharArray();
string reverseUsername = String.Empty;
for (int i = cArray.Length - 1; i > -1; i--)
{
    reverseUsername += cArray[i];
}

//OUTPUT
Console.WriteLine(reverseUsername);