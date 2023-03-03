//INPUT
string info = string.Empty;

//ACTION
Dictionary<string, decimal> productsDictionary = new Dictionary<string, decimal>();

while ((info = Console.ReadLine()) != "buy")
{
    string[] infoArray = info.Split();

    string productName = infoArray[0];
    decimal productPrice = decimal.Parse(infoArray[1]);
    int productCount = int.Parse(infoArray[2]);

    if (!productsDictionary.ContainsKey(productName))
    {
        productsDictionary.Add(productName, productPrice * productCount);
    }
    else
    {
        productsDictionary[productName] += productPrice * productCount;
    }
}

//OUTPUT
foreach (var product in productsDictionary)
{
    Console.WriteLine($"{product.Key} -> {product.Value:f2}");
}