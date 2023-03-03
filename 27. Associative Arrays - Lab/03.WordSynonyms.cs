//INPUT
int wordsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

for (int i = 0; i < wordsCount; i++)
{
	string word = Console.ReadLine();
	string synonym = Console.ReadLine();

    if (!words.ContainsKey(word))
	{
        List<string> synonymsList = new List<string>();

        synonymsList.Add(synonym);
		words.Add(word, synonymsList);
	}
	else
	{
        words[word].Add(synonym);
	}
}

//OUTPUT
foreach (var currentWordAndSynonym in words)
{
	Console.WriteLine($"{currentWordAndSynonym.Key} - {String.Join(", ", currentWordAndSynonym.Value)}");
}