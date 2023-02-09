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
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        Console.WriteLine();
    }
    else if (command == "PrintOdd")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        Console.WriteLine();
    }
    else if (command == "GetSum")
    {
        int numsSum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            numsSum += numbers[i];
        }
        Console.WriteLine(numsSum);
    }
    else if (command.Contains("Filter") == true)
    {
        string[] commandArray = command.Split();
        string condition = commandArray[1];
        int value = int.Parse(commandArray[2]);

        //Return Value
        if (condition == "<")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < value)
                {
                    Console.Write($"{numbers[i]}");
                }
            }
        }
        else if (condition == ">")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > value)
                {
                    Console.Write($"{numbers[i]}");
                }
            }
        }
        else if (condition == ">=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= value)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == "<=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= value)
                {
                    Console.Write($"{numbers[i]}");
                }
            }
        }
    }
}

//Original List Changes Checker
if (madeChanges == true)
{
    Console.WriteLine(String.Join(" ", numbers));
}