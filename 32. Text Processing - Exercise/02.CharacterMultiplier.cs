//INPUT
string[] stringsInput = Console.ReadLine().Split();
string stringOne = stringsInput[0];
string stringTwo = stringsInput[1];

//OUTPUT
Console.WriteLine(CharacterMultiplier(stringOne, stringTwo));

//ACTION
static int CharacterMultiplier(string stringOne, string stringTwo)
{
    //Multiplication Length
    int multiplicationLength = 0;
    bool areEqual = false;

    if (stringOne.Length >= stringTwo.Length)
    {
        multiplicationLength = stringTwo.Length;

        if (stringOne.Length == stringTwo.Length)
        {
            areEqual = true;
        }
    }
    else
    {
        multiplicationLength = stringOne.Length;
    }

    //Multiplicator
    int sum = 0;
    char[] stringOneCharArr = stringOne.ToCharArray();
    char[] stringTwoCharArr = stringTwo.ToCharArray();

    for (int i = 0; i < multiplicationLength; i++)
    {
        sum += stringOneCharArr[i] * stringTwoCharArr[i];
    }

    //Not Equal Case
    if (!areEqual)
    {
        if (stringOne.Length > stringTwo.Length)
        {
            multiplicationLength = stringOne.Length - stringTwo.Length;
            for (int i = stringOne.Length - multiplicationLength; i < stringOne.Length; i++)
            {
                sum += stringOneCharArr[i];
            }
        }
        else
        {
            multiplicationLength = stringTwo.Length - stringOne.Length;
            for (int i = stringTwo.Length - multiplicationLength; i < stringTwo.Length; i++)
            {
                sum += stringTwoCharArr[i];
            }
        }
    }

    return sum;
}