using System;
using System.Collections.Generic;

namespace Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ");

                string keyName = command[0];
                string id = command[1];

                if (!dictionary.ContainsKey(keyName))
                {
                    dictionary.Add(keyName, new List<string>());
                }
                if (dictionary[keyName].Contains(id))
                {
                    continue;
                }
                dictionary[keyName].Add(id);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                foreach (var user in item.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
