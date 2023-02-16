//INPUT
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

//ACTION
string command = string.Empty;
bool madeChanges = false;

while ((command = Console.ReadLine()) != "end")
{
    if (command.Contains("Add") == true)
    {
        madeChanges = true;
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);

        //Return Value:
        numbers.Add(value);
    }
    else if (command.Contains("RemoveAt") == true)
    {
        madeChanges = true;
        string[] commandArray = command.Split();
        int index = int.Parse(commandArray[1]);

        //Return Value:
        numbers.RemoveAt(index);
    }
    else if (command.Contains("Remove") == true)
    {
        madeChanges = true;
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);

        //Return Value:
        numbers.Remove(value);
    }
    else if (command.Contains("Insert") == true)
    {
        madeChanges = true;
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);
        int index = int.Parse(commandArray[2]);

        //Return Value:
        numbers.Insert(index, value);
    }
    else if (command.Contains("Contains") == true)
    {
        string[] commandArray = command.Split();
        int value = int.Parse(commandArray[1]);

        //Return Value:
        if (numbers.Contains(value))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        List<int> evenNumbersList = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbersList.Add(numbers[i]);
            }
        }
        Console.WriteLine(String.Join(" ", evenNumbersList));
    }
    else if (command == "PrintOdd")
    {
        List<int> oddNumbersList = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                oddNumbersList.Add(numbers[i]);
            }
        }
        Console.WriteLine(String.Join(" ", oddNumbersList));
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command.Contains("Filter") == true)
    {
        string[] commandArray = command.Split();
        string condition = commandArray[1];
        int value = int.Parse(commandArray[2]);

        List<int> conditionNumbersList = new List<int>();

        //Return Value
        if (condition == "<")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < value)
                {
                    conditionNumbersList.Add(numbers[i]);
                }
            }
        }
        else if (condition == ">")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > value)
                {
                    conditionNumbersList.Add(numbers[i]);
                }
            }
        }
        else if (condition == ">=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= value)
                {
                    conditionNumbersList.Add(numbers[i]);
                }
            }
        }
        else if (condition == "<=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= value)
                {
                    conditionNumbersList.Add(numbers[i]);
                }
            }
        }
        Console.WriteLine(String.Join(" ", conditionNumbersList));
    }
}

//Original List Changes Checker
if (madeChanges == true)
{
    Console.WriteLine(String.Join(" ", numbers));
}
