//INPUT
List<int> targetsList = Console.ReadLine().Split().Select(int.Parse).ToList();

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split();

    //Shoot
    if (command.Contains("Shoot"))
	{
        int index = Convert.ToInt32(commandArray[1]);
        int power = Convert.ToInt32(commandArray[2]);

        //Index Ckeck
        if (index >= 0 && index < targetsList.Count)
        {
            //Shoot
            targetsList[index] -= power;

            //If Shot
            if (targetsList[index] <= 0)
            {
                targetsList.RemoveAt(index);
            }
        }
    }

    //Add
    else if (command.Contains("Add"))
    {
        int index = Convert.ToInt32(commandArray[1]);
        int value = Convert.ToInt32(commandArray[2]);

        //Index Check
        if (index >= 0 && index < targetsList.Count)
        {
            targetsList.Insert(index, value);
        }
        else
        {
            Console.WriteLine("Invalid placement!");
        }
    }

    //Strike
    else if (command.Contains("Strike"))
    {
        int index = Convert.ToInt32(commandArray[1]);
        int radius = Convert.ToInt32(commandArray[2]);
        
        int startIndex = index - radius;
        int endIndex = index + radius;

        //Indexes Checker
        if (startIndex >= 0 && startIndex < targetsList.Count && endIndex >= 0 && endIndex < targetsList.Count)
        {
            targetsList.RemoveRange(startIndex, radius*2 +1);
        }
        else
        {
            Console.WriteLine("Strike missed!");
        }
    }
}

//OUTPUT
Console.WriteLine(String.Join("|", targetsList));