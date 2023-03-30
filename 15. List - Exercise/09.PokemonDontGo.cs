using System;
using System.Collections.Generic;
using System.Linq;

class PokemonDontGo
{
    static void ListModify(List<int> list, int currentOut)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] <= currentOut)
            {
                list[i] += currentOut;
            }
            else
            {
                list[i] -= currentOut;
            }
        }
    }

    static void Main(string[] args)
    {
        //INPUT
        List<int> list = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        //ACTION
        int sum = 0;
        int currentOut = 0;

        while (list.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            if (index < 0)
            {
                currentOut = list[0];
                list[0] = list[list.Count - 1];
            }
            else if (index > list.Count - 1)
            {
                currentOut = list[list.Count - 1];
                list[list.Count - 1] = list[0];
            }
            else
            {
                currentOut = list[index];
                list.RemoveAt(index);
            }

            ListModify(list, currentOut);
            sum += currentOut;

        }

        //OUTPUT
        Console.WriteLine(sum);
    }
}