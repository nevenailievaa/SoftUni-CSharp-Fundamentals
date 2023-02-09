//INPUT
int productsCount = int.Parse(Console.ReadLine());

//ACTION
List<string> productsList = new List<string>();

//Products Input
for (int i = 0; i < productsCount; i++)
{
    productsList.Add(Console.ReadLine());
}

//Order By Name
productsList.Sort();

//OUTPUT
for (int j = 1; j <= productsCount; j++)
{
    Console.WriteLine($"{j}.{productsList[j-1]}");
}