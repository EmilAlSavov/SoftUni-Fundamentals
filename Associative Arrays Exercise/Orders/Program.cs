using System;
using System.Collections.Generic;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> items = new Dictionary<string, List<double>>();

            string input = "";
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split();
                string keyName = command[0];
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!items.ContainsKey(keyName))
                {
                    items.Add(keyName, new List<double>() { 0, 0});
                }
                items[keyName][0] = price;
                items[keyName][1] += quantity;
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
            }
        }
    }
}
