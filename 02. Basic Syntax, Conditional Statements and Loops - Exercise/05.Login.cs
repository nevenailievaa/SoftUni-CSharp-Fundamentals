//INPUT
using static System.Net.Mime.MediaTypeNames;

string username = Console.ReadLine();
string password = Console.ReadLine();

//CHANGEABLE
int attempt = 0;

//ACTION
//Reverse
char[] cArray = username.ToCharArray();
string reverseUsername = String.Empty;
for (int i = cArray.Length - 1; i > -1; i--)
{
    reverseUsername += cArray[i];
}

//OUTPUT
while (attempt != 3)
{
    attempt++;
    if (password != reverseUsername)
    {
        Console.WriteLine("Incorrect password. Try again.");
        password = Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"User {username} logged in.");
        return;
    }
}
Console.WriteLine($"User {username} blocked!");