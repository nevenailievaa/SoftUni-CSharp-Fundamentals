//INPUT
int phrasesCount = int.Parse(Console.ReadLine());

//ACTION
string[] phrases = new string[]
{
    "Excellent product.",
    "Such a great product.",
    "I always use that product.",
    "Best product of its category.",
    "Exceptional product.",
    "I can't live without this product."
};

string[] events = new string[]
{
    "Now I feel good.",
    "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.",
    "I feel great!"
};

string[] authors = new string[]
{
    "Diana",
    "Petya",
    "Stella",
    "Elena",
    "Katya",
    "Iva",
    "Annie",
    "Eva"
};

string[] cities = new string[]
{
    "Burgas",
    "Sofia",
    "Plovdiv",
    "Varna",
    "Ruse"
};

//OUTPUT
Random random = new Random();

for (int i = 1; i <= phrasesCount; i++)
{
    int currentPhrase = random.Next(phrases.Length);
    int currentEvent = random.Next(events.Length);
    int currentAuthor = random.Next(authors.Length);
    int currentCity = random.Next(cities.Length);

    Console.WriteLine($"{phrases[currentPhrase]} {events[currentEvent]} {authors[currentAuthor]} - {cities[currentCity]}.");
}