//INPUT
string[] words = Console.ReadLine().Split();

//ACTION
for (int i = 0; i < words.Length - 1; i++)
{
    Random random = new Random();
    int randomIndex = random.Next(0, words.Length);

    string currentWord = words[i];

    while (i == randomIndex)
    {
        randomIndex = random.Next(0, words.Length);
    }

    string wordSwap = words[randomIndex];

    words[i] = wordSwap;
    words[randomIndex] = currentWord;
}

//OUTPUT
Console.WriteLine(string.Join(Environment.NewLine, words));
