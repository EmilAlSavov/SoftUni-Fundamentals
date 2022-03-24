using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').Select(x => x.ToLower()).ToList();
                for (int i = 0; i < input.Count; i+=2)
                {
                    string material = input[i + 1];
                    int quantity = int.Parse(input[i]);

                    if (!dictionary.ContainsKey(material))
                    {
                        dictionary.Add(material, quantity);
                    }
                    else
                    {
                        dictionary[material] += quantity;
                    }

                    if (CheckIfMaterialsAreEnough(dictionary))
                    {
                        if (isItShards(dictionary))
                        {
                            dictionary["shards"] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            PrintEndResult(dictionary);
                            return;
                        }
                        else if (isItFragments(dictionary))
                        {
                            dictionary["fragments"] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            PrintEndResult(dictionary);
                            return;
                        }
                        else if (isItMotes(dictionary))
                        {
                            dictionary["motes"] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            PrintEndResult(dictionary);
                            return;
                        }
                    }
                }
            }

            
        }

        static void PrintEndResult(Dictionary<string, int> dictionary)
        {
            Dictionary<string, int> junkItems = dictionary
                .Where(d => d.Key != "shards" && d.Key != "fragments" && d.Key != "motes")
                .ToDictionary(d => d.Key, d => d.Value);

            if (!dictionary.ContainsKey("shards"))
            {
                Console.WriteLine($"shards: 0");
            }
            else
            {
                Console.WriteLine($"shards: {dictionary["shards"]}");
            }

            if (!dictionary.ContainsKey("motes"))
            {
                Console.WriteLine($"motes: 0");
            }
            else
            {
                Console.WriteLine($"motes: {dictionary["motes"]}");
            }

            if (!dictionary.ContainsKey("fragments"))
            {
                Console.WriteLine($"fragments: 0");
            }
            else
            {
                Console.WriteLine($"fragments: {dictionary["fragments"]}");
            }

            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static bool CheckIfMaterialsAreEnough(Dictionary<string, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                if (item.Key == "shards" || item.Key == "fragments" || item.Key == "motes")
                {
                    if (item.Value >= 250)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool isItShards(Dictionary<string, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                if (item.Key == "shards")
                {
                    if (item.Value >= 250)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool isItFragments(Dictionary<string, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                if (item.Key == "fragments")
                {
                    if (item.Value >= 250)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool isItMotes(Dictionary<string, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                if (item.Key == "motes")
                {
                    if (item.Value >= 250)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
