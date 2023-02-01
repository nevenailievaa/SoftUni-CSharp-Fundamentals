//INPUT
int n = int.Parse(Console.ReadLine());

//CHANGEABLE
int[] outputArray = new int[n];

//ACTION
for (int i = 0; i < n; i++)
{
    string inputString = Console.ReadLine();
    char[] inputArrayChar = new char[inputString.Length];

    //Sums Restart
    int vowelsSum = 0;
    int constantsSum = 0;
    int allLettersSum = 0;

    //String To Char Array Convert
    for (int k = 0; k < inputString.Length; k++)
    {
	inputArrayChar[k] = inputString[k];
    }

    //Word Letters Checker
    for (int j = 0; j < inputString.Length; j++)
    {
        //Vowel Or Constant Checker
        if (inputArrayChar[j] == 'a' || inputArrayChar[j] == 'e' || inputArrayChar[j] == 'i' || inputArrayChar[j] == 'o' || inputArrayChar[j] == 'u' || inputArrayChar[j] == 'A' || inputArrayChar[j] == 'E' || inputArrayChar[j] == 'I' || inputArrayChar[j] == 'O' || inputArrayChar[j] == 'U')
        {
            vowelsSum += inputArrayChar[j] * inputArrayChar.Length;
        }
        else
        {
            constantsSum += inputArrayChar[j] / inputArrayChar.Length;
        }
    }

    //Name Letters Sum
    allLettersSum = vowelsSum + constantsSum;
    outputArray[i] = allLettersSum;
}

//OUTPUT
Array.Sort(outputArray);
for (int o = 0; o < n; o++)
{
    Console.WriteLine(outputArray[o]);
}
