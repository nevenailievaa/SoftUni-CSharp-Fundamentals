using System.Text;
using System.Text.RegularExpressions;

//INPUT
int barcodesCount = int.Parse(Console.ReadLine());

//ACTION
Regex barcodeRegex = new Regex(@"^(?<startSymbols>@#+)(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])(?<endSymbols>@#+)$");

for (int i = 0; i < barcodesCount; i++)
{
    string currentBarcode = Console.ReadLine();

	if (barcodeRegex.IsMatch(currentBarcode))
	{
		StringBuilder currentGroup = new StringBuilder("00");
		if (currentBarcode.Any(char.IsDigit))
		{
			currentGroup.Clear();
			for (int j = 0; j < currentBarcode.Length; j++)
			{
				if (char.IsDigit(currentBarcode[j]))
				{
					currentGroup.Append(currentBarcode[j]);
                }
			}
		}
		Console.WriteLine($"Product group: {currentGroup}");
    }
	else
	{
		Console.WriteLine("Invalid barcode");
	}
}