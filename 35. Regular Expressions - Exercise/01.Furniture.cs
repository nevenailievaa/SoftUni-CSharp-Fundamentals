using System.Linq;
using System.Text.RegularExpressions;

//INPUT
string input = String.Empty;

//ACTION
Regex regex = new Regex(@"\B>>(?<furniture>[A-z]+)<<(?<price>\d+(\.*\d*))!(?<quantity>\d+)");
List<string> purchasedItems = new List<string>();
double sum = 0;


while ((input = Console.ReadLine()) != "Purchase")
{
    MatchCollection purchase = regex.Matches(input);

    foreach (Match item in purchase)
    {
        string name = item.Groups["furniture"].Value;
        double price = double.Parse(item.Groups["price"].Value);
        int quantity = int.Parse(item.Groups["quantity"].Value);
        purchasedItems.Add(name);
        sum += price * quantity;
    }
}

//OUTPUT
Console.WriteLine("Bought furniture:");

if (purchasedItems.Count > 0)
{
    Console.WriteLine(String.Join("\n", purchasedItems));
}

Console.WriteLine($"Total money spend: {sum:f2}");


//Create a program to calculate the total cost of different types of furniture.
//You will be given some lines of input, until you receive the line "Purchase".
//For the line to be valid it should be in the following format:

//">>{furniture name}<<{price}!{quantity}"

//The price can be a floating-point number or a whole number.
//Store the names of the furniture and the total price. At the
//end, print each bought furniture on a separate line.
