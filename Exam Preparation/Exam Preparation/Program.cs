using System;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double sumWithoutTaxes = 0;
            while ((input = Console.ReadLine()) != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                sumWithoutTaxes+=price;
            }
            if (sumWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sumWithoutTaxes:F2}$");
            double taxes = sumWithoutTaxes * 0.20;
            Console.WriteLine($"Taxes: {taxes:F2}$");
            double sumTaxes = taxes + sumWithoutTaxes;
            if (input == "special")
            {
                sumTaxes = sumTaxes - (sumTaxes * 0.10);
            }
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {sumTaxes:F2}$");
        }
    }
}
