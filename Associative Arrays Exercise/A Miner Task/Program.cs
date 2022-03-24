using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string input = "";

            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(resource))
                {
                    dictionary.Add(resource, quantity);
                }
                else
                {
                    dictionary[resource] += quantity;
                }

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
