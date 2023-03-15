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

//Create a program that returns an encrypted version of the same text.
//Encrypt the text by shifting each character with three positions forward.
//For example, A would be replaced by D, B would become E and so on.
//Print the encrypted text.
