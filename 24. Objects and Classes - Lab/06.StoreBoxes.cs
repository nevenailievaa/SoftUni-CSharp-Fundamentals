//INPUT
string info = string.Empty;

//ACTION
List<Box> boxesList = new List<Box>();

while ((info = Console.ReadLine()) != "end")
{
    string[] infoAsArray = info.Split();

    int serialNumber = int.Parse(infoAsArray[0]);
    string itemName = infoAsArray[1];
    int itemQuantity = int.Parse(infoAsArray[2]);
    decimal ItemPrice = decimal.Parse(infoAsArray[3]);

    Item item = new Item
    {
        Name = itemName,
        Price = ItemPrice
    };

    Box box = new Box
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = itemQuantity,
        PriceForBox = ItemPrice * itemQuantity
    };

    boxesList.Add(box);
}

//Order By Descending
foreach (var box in boxesList.OrderByDescending(x => x.PriceForBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForBox:f2}");
}

//Class Box
public class Box
{
    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForBox { get; set; }
}

//Class Item
public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}