//INPUT
string[] fileLocation = Console.ReadLine().Split(@"\");

//ACTION
string[] nameAndExtension = fileLocation[fileLocation.Length -1].Split(".");
string fileName = nameAndExtension[0];
string fileExtension = nameAndExtension[1];

//OUTPUT
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");