//INPUT
string[] articleArray = Console.ReadLine().Split(", ").ToArray();
int commandsCount = int.Parse(Console.ReadLine());

//Info
string title = articleArray[0];
string content = articleArray[1];
string author = articleArray[2];
Article article = new Article(title, content, author);

//ACTION
for (int i = 0; i < commandsCount; i++)
{
    string[] currentCommandArray = Console.ReadLine().Split(": ").ToArray();

    if (currentCommandArray[0] == "Edit")
    {
        article.Content = currentCommandArray[1];
    }
    else if (currentCommandArray[0] == "ChangeAuthor")
    {
        article.Author = currentCommandArray[1];
    }
    else if (currentCommandArray[0] == "Rename")
    {
        article.Title = currentCommandArray[1];
    }
}

//OUTPUT
Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

//Article Class
public class Article
{
    public Article (string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}