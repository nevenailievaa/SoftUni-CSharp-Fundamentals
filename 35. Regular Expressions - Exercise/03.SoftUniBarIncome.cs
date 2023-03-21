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