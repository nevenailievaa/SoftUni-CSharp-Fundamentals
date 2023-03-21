using System.Diagnostics;
using System.Text.RegularExpressions;

//INPUT
string input = string.Empty;

//ACTION
Regex nameRegex = new Regex(@"%(?<name>[A-Z][a-z]+)%");
Regex productRegex = new Regex(@"<(?<product>\w+)>");
Regex quantityRegex = new Regex(@"\|(?<quantity>\d+)\|");
Regex priceRegex = new Regex(@"(?<price>\d+(\.*\d*))\$");

double sum = 0;

while ((input = Console.ReadLine()) != "end of shift")
{
    bool validName = nameRegex.IsMatch(input);
    bool validProduct = productRegex.IsMatch(input);
    bool validQuantity = quantityRegex.IsMatch(input);
    bool validPrice = priceRegex.IsMatch(input);

    if (validName && validProduct && validQuantity && validPrice)
    {
        Match name = nameRegex.Match(input);
        Match product = productRegex.Match(input);
        Match quantity = quantityRegex.Match(input);
        Match price = priceRegex.Match(input);

        double currentPrice = int.Parse(quantity.Groups["quantity"].Value) * double.Parse(price.Groups["price"].Value);
        sum += currentPrice;

        //OUTPUT
        Console.WriteLine($"{name.Groups["name"]}: {product.Groups["product"]} - {currentPrice:f2}");
    }
}

//OUTPUT
Console.WriteLine($"Total income: {sum:f2}");


//Let's take a break and visit the game bar at SoftUni.
//It is about time for the people behind the bar to go home and you are the person
//who has to draw the line and calculate the money from the products that were sold
//throughout the day. Until you receive a line with the text "end of shift", you will
//be given lines of input. But before processing that line, you have to do some
//validations first.

//Each valid order should have a customer, product, count and a price:

//· A valid customer's name should be surrounded by '%' and must start with a capital letter,
//followed by lower-case letters.
//· A valid product contains any word character and must be surrounded by '<' and '>' .
//· A valid count is an integer, surrounded by '|'.
//· A valid price is any real number followed by '$'.

//The parts of a valid order should appear in the order given: customer, product, count and price.
//Between each part there can be other symbols, except '|', '$', '%' and '.'.
//For each valid line, print on the console: "{customerName}: {product} - {totalPrice}".

//When you receive "end of shift" print the total amount of money for the day, rounded to 2 decimal
//places in the following format: "Total income: {income}"
