//INPUT
int n = int.Parse(Console.ReadLine());

//ACTION
bool isBalanced = true;
bool openedBracket = false;

for (int line = 0; line < n; line++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        if (openedBracket)
        {
            isBalanced = false;
        }
        else
        {
            openedBracket = true;
        }
    }
    else if (input == ")")
    {
        if (openedBracket)
        {
            openedBracket = false;
        }
        else
        {
            isBalanced = false;
        }
    }
}

//OUTPUT
if (openedBracket)
{
    isBalanced = false;
}
Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");