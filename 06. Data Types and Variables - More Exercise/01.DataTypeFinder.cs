//INPUT
string input = Console.ReadLine();

//ACTION
while (input != "END")
{
    if (int.TryParse(input, out int number))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (bool.TryParse(input, out Boolean value))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else if (char.TryParse(input, out Char symbol))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (double.TryParse(input, out double floatnumber))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }

    input = Console.ReadLine();
}