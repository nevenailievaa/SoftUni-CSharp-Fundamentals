//INPUT
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string text = Console.ReadLine();

//ACTION
List<int> numbersDigitsSums= new List<int>();

//Sum of every elements digits
for (int i = 0; i < numbers.Count; i++)
{
    int currentNumSum = 0;
    string currentNumString = Convert.ToString(numbers[i]);

    for (int j = 0; j < currentNumString.Length; j++)
    {
        int currentNumInt = Convert.ToInt32(currentNumString[j].ToString());
        currentNumSum += currentNumInt;
    }

    numbersDigitsSums.Add(currentNumSum);
}

List<string> textString= text.Select(x => x.ToString()).ToList();

for (int k = 0; k < numbersDigitsSums.Count; k++)
{
    //Length Checker
    while (numbersDigitsSums[k] > textString.Count)
    {
        numbersDigitsSums[k] -= textString.Count;
    }

    //OUTPUT
    Console.Write(textString[numbersDigitsSums[k]]);
    //Current element remover
    textString.RemoveAt(numbersDigitsSums[k]);
}