using System.Collections;
using System.Collections.Generic;

//INPUT
int pianoPiecesCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, ComposerAndKey> pieces = new Dictionary<string, ComposerAndKey>();

for (int i = 0; i < pianoPiecesCount; i++)
{
    string[] piecesInput = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    string piece = piecesInput[0];
    string composer = piecesInput[1];
    string key = piecesInput[2];

    ComposerAndKey currentComposerAndKey = new ComposerAndKey(composer, key);
    pieces.Add(piece, currentComposerAndKey);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "Stop")
{
    string[] commandArray = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

    //Add Command
    if (command.Contains("Add"))
    {
        string piece = commandArray[1];
        string composer = commandArray[2];
        string key = commandArray[3];

        if (pieces.ContainsKey(piece))
        {
            Console.WriteLine($"{piece} is already in the collection!");
        }
        else
        {
            ComposerAndKey currentComposerAndKey = new ComposerAndKey(composer, key);
            pieces.Add(piece, currentComposerAndKey);

            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
    }

    //Remove Command
    else if (command.Contains("Remove"))
    {
        string piece = commandArray[1];

        if (pieces.ContainsKey(piece))
        {
            pieces.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }

    //ChangeKey Command
    else if (command.Contains("ChangeKey"))
    {
        string piece = commandArray[1];
        string key = commandArray[2];

        if (pieces.ContainsKey(piece))
        {
            pieces[piece].Key = key;
            Console.WriteLine($"Changed the key of {piece} to {key}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
}

//OUTPUT
foreach (var piece in pieces)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
}

//Composer With Key Class
public class ComposerAndKey
{
    public string Composer { get; set; }
    public string Key { get; set; }

    public ComposerAndKey (string composer, string key)
    {
        Composer = composer;
        Key = key;
    }
}