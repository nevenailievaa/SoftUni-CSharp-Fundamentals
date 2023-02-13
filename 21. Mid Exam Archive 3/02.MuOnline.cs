using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            List<string> dungeonRooms = Console.ReadLine().Split("|").ToList();

            //ACTION
            int initialHealth = 100;
            int initialBitcoins = 0;
            int bestRoom = 0;

            for (int i = 0; i < dungeonRooms.Count; i++)
            {
                bestRoom = i;

                string[] currentRoom = dungeonRooms[i].Split();
                int number = Convert.ToInt32(currentRoom[1].ToString());

                //Potion Command
                if (currentRoom[0] == "potion")
                {
                    if (initialHealth + number <= 100)
                    {
                        initialHealth += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                        initialHealth = 100;
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }

                //Chest Command
                else if (currentRoom[0] == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    initialBitcoins += number;
                }

                //Monster Attack
                else
                {
                    initialHealth -= number;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {currentRoom[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {currentRoom[0]}.");
                        bestRoom++;
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                }
            }

            //FINAL OUTPUT
            if (initialHealth > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
