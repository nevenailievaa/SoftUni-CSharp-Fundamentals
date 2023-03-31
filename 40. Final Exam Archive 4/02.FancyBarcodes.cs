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

//Your first task is to determine if the given sequence of characters is a valid barcode or not. 

//Each line must not contain anything else but a valid barcode. A barcode is valid when:
// - It is surrounded by a "@" followed by one or more "#"
// - It is at least 6 characters long (without the surrounding "@" or "#")
// - It starts with a capital letter
// - It contains only letters (lower and upper case) and digits
// - It ends with a capital letter

//Examples of valid barcodes: @###Che46sE@##, @#FreshFisH@#, @###Brea0D@###, @##Che46sE@##
//Examples of invalid barcodes: ##InvaliDiteM##, @InvalidIteM@, @#Invalid_IteM@#

//Next, you have to determine the product group of the item from the barcode. The product group is
//obtained by concatenating all the digits found in the barcode. If there are no digits present in
//the barcode, the default product group is "00".

//Examples:  
//@#FreshFisH@# -> product group: 00
//@###Brea0D@### -> product group: 0
//@##Che4s6E@## -> product group: 46
