using System.Text;

//INPUT
int namesCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<StringBuilder, StringBuilder> names = new Dictionary<StringBuilder, StringBuilder>();

for (int k = 0; k < namesCount; k++)
{
    string personInfo = Console.ReadLine();

    StringBuilder name = new StringBuilder();
    StringBuilder age = new StringBuilder();

    int startName = personInfo.IndexOf('@');
    int endName = personInfo.IndexOf('|');

    int startAge = personInfo.IndexOf('#');
    int endAge = personInfo.IndexOf('*');

    for (int i = startName +1; i < endName; i++)
    {
        name.Append(personInfo[i]);
    }
    for (int j = startAge +1; j < endAge; j++)
    {
        age.Append(personInfo[j]);
    }

    names.Add(name, age);
}

//OUTPUT
foreach (var person in names)
{
    Console.WriteLine($"{person.Key} is {person.Value} years old.");
}


//Create a program that reads N lines of strings and extracts the name
//and age of a given person. The name of the person will be between '@'
//and '|'. The person's age will be between '#' and '*'.

//Example: "Hello my name is @Peter| and I am #20* years old."

//For each found name and age print a line in the following format
//"{name} is {age} years old."