//INPUT
string[] inputWords = Console.ReadLine().ToLower().Split().ToArray();

//ACTION
Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

foreach (var word in inputWords)
{
    if (!wordsDictionary.ContainsKey(word))
    {
        wordsDictionary.Add(word, 1);
    }
    else
    {
        wordsDictionary[word]++;
    }
}

//OUTPUT
foreach (var word in wordsDictionary)
{
    if (word.Value % 2 == 1)
    {
        Console.Write($"{word.Key} ");
    }
}