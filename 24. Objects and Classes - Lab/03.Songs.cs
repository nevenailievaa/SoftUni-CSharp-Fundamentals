//INPUT
using System.ComponentModel;

int songsCount = int.Parse(Console.ReadLine());
string outputType = string.Empty;

//ACTION
List<Song> songs = new List<Song>();

for (int i = 0; i < songsCount; i++)
{
    string[] songArray = Console.ReadLine().Split("_");
    Song currentSong = new Song();

    currentSong.TypeList = songArray[0];
    currentSong.Name = songArray[1];
    currentSong.Time = songArray[2];

    songs.Add(currentSong);
}

//OUTPUT
outputType = Console.ReadLine();

if (outputType == "all")
{
    foreach (Song currentSong in songs)
    {
        Console.WriteLine(currentSong.Name);
    }
}
else
{
    foreach (Song currentSong in songs)
    {
        if (currentSong.TypeList == outputType)
        {
            Console.WriteLine(currentSong.Name);
        }
    }
}

//Song Class
public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}
