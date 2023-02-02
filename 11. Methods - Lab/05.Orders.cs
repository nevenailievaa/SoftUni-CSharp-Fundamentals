using System;
public class Grades
{
    static void Main()
    {
        //INPUT
        string typeProduct = Console.ReadLine();
        double productQuantity = double.Parse(Console.ReadLine());

        //OUTPUT
        Calculation(typeProduct, productQuantity);
    }

    //ACTION
    static void Calculation(string product, double quantity)
    {
        //Prices
        double coffeePrice = 1.50;
        double waterPrice = 1.00;
        double cokePrice = 1.40;
        double snacksPrice = 2.00;

        //Calculation
        if (product == "coffee")
        {
            Console.WriteLine($"{coffeePrice * quantity:f2}");
        }
        else if (product == "water")
        {
            Console.WriteLine($"{waterPrice * quantity:f2}");
        }
        else if (product == "coke")
        {
            Console.WriteLine($"{cokePrice * quantity:f2}");
        }
        else if (product == "snacks")
        {
            Console.WriteLine($"{snacksPrice * quantity:f2}");
        }
    }
}
