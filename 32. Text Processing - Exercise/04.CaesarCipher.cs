using System.Text;

//INPUT
char[] text = Console.ReadLine().ToCharArray();

//ACTION
List<char> encryptedText = new List<char>();

for (int i = 0; i < text.Length; i++)
{
    int currEncryptedCharValue = text[i] + 3;
    encryptedText.Add((char)currEncryptedCharValue);

    //OUTPUT
    Console.Write(encryptedText[i]);
}