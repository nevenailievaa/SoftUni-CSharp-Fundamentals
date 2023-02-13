using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            List<string> itemsList = Console.ReadLine().Split(", ").ToList();

            //ACTION
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] commandArray = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                //Collect Command
                if (commandArray[0] == "Collect")
                {
                    string item = commandArray[1];
                    bool itemContains = false;

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == item)
                        {
                            itemContains = true;
                            break;
                        }
                    }
                    if (itemContains == false)
                    {
                        itemsList.Add(item);
                    }
                }

                //Drop Command
                else if (commandArray[0] == "Drop")
                {
                    string item = commandArray[1];

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == item)
                        {
                            itemsList.RemoveAt(i);
                        }
                    }
                }

                //Combine Command
                else if (commandArray[0] == "Combine Items")
                {
                    string[] itemsArray = commandArray[1].Split(":").ToArray();
                    string oldItem = itemsArray[0];
                    string newItem = itemsArray[1];

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == oldItem)
                        {
                            itemsList.Insert(i+1, newItem);
                        }
                    }
                }

                //Renew Command
                else if (commandArray[0] == "Renew")
                {
                    string item = commandArray[1];

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == item)
                        {
                            itemsList.RemoveAt(i);
                            itemsList.Add(item);
                        }
                    }
                }
            }

            //OUTPUT
            Console.WriteLine(string.Join(", ", itemsList));
        }
    }
}