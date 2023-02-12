using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //INPUT
           List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            //ACTION
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                //Command In An Array
                List<string> commandArray = new List<string>(command.Split(' '));

                //Urgent Case
                if (command.Contains("Urgent"))
                {
                    string item = commandArray[1].ToString();
                    bool containsProduct = false;

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == item)
                        {
                            containsProduct = true;
                            break;
                        }
                    }
                    if (containsProduct == false)
                    {
                        shoppingList.Insert(0, item);
                    }
                }

                //Unnecessary Case
                else if (command.Contains("Unnecessary"))
                {
                    string item = commandArray[1].ToString();

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == item)
                        {
                            shoppingList.Remove(item);
                        }
                    }
                }

                //Correct Case
                else if (command.Contains("Correct"))
                {
                    string oldItem = commandArray[1].ToString();
                    string newItem = commandArray[2].ToString();

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == oldItem)
                        {
                            shoppingList[i] = newItem;
                        }
                    }
                }

                //Rearrange Case
                else if (command.Contains("Rearrange"))
                {
                    string item = commandArray[1].ToString();

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == item)
                        {
                            shoppingList.RemoveAt(i);
                            shoppingList.Add(item);
                        }
                    }
                }
            }

            //OUTPUT
            Console.WriteLine(String.Join(", ", shoppingList));
        }
    }
}
