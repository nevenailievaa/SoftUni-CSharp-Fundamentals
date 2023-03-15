//INPUT
char startChar = char.Parse(Console.ReadLine());
char endChar = char.Parse(Console.ReadLine());
string inputString = Console.ReadLine();

//ACTION
List<char> chars = new List<char>();
List<char> outputChars = new List<char>();

for (int i = startChar; i < endChar; i++)
{
    char currentChar = (char)i;
    chars.Add(currentChar);
}

int sum = 0;

for (int i = 0; i < chars.Count; i++)
{
    for (int j = 0; j < inputString.Length; j++)
    {
        if (chars[i] == inputString[j])
        {
            sum += chars[i];
        }
    }
}

//OUTPUT
Console.WriteLine(sum);


//Create a program that prints a sum of all characters between
//two given characters (their ASCII code). On the first line,
//you will get a character. On the second line, you get another
//character. On the last line, you get a random string. Find all
//the characters between the two given and print their ASCII sum.