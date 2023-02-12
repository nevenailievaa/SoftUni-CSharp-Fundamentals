using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int[] neighbourHood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            //ACTION
            string command = Console.ReadLine();
            int houseIndex = 0;

            while (command.Contains("Jump"))
            {
                string[] commandArray = command.Split();
                int currentJumpLength = Convert.ToInt32(commandArray[1]);

                houseIndex += currentJumpLength;

                if (houseIndex >= neighbourHood.Length || houseIndex < 0)
                {
                    houseIndex = 0;
                }

                if (neighbourHood[houseIndex] == 0)
                {
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                }
                else
                {
                    neighbourHood[houseIndex] -= 2;
                    if (neighbourHood[houseIndex] == 0)
                    {
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }

            //Failed Places Counter
            int failedPlacesCount = 0;

            for (int i = 0; i < neighbourHood.Length; i++)
            {
                if (neighbourHood[i] != 0)
                {
                    failedPlacesCount++;
                }
            }

            //OUTPUT
            int lastPosition = houseIndex;
            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            if (failedPlacesCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedPlacesCount} places.");
            }
        }
    }
}
