//INPUT
List<Article> articleList = new List<Article>();
int commandsCount = int.Parse(Console.ReadLine());

//ACTION
for (int i = 1; i <= commandsCount; i++)
{
    string[] inputs = Console.ReadLine().Split(", ");

    string title = inputs[0];
    string content = inputs[1];
    string author = inputs[2];

    Article article = new Article(title, content, author);

    articleList.Add(article);
}

string command = Console.ReadLine();

//OUTPUT
foreach (var currentArticle in articleList)
{
    Console.WriteLine(currentArticle);
}

//Article Class
class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{this.Title} - {this.Content}: {this.Author}";
    }
}