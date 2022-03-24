using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class Plant
    {
        public Plant()
        {
            Rating = new List<double>() { 0 };
        }
        public string Name { get; set; }

        public int Rarity { get; set; }

        public List<double> Rating { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Plant> plants = PutPlants(n);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];

                if (commandType == "Rate")
                {
                    string[] properties = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    
                    string name = properties[0];
                    int rating = int.Parse(properties[1]);

                    var currentPlant = plants.FirstOrDefault(x => x.Name == name);
                    if (currentPlant != null)
                    {
                        currentPlant.Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType == "Update")
                {
                    string[] properties = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                    string name = properties[0];
                    int newRarity = int.Parse(properties[1]);

                    var currPlant = plants.FirstOrDefault(plants => plants.Name == name);

                    if (currPlant != null)
                    {
                        currPlant.Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType == "Reset")
                {
                    string[] properties = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                    string name = properties[0];

                    var currPlant = plants.FirstOrDefault(plants => plants.Name == name);

                    if (currPlant != null)
                    {
                        currPlant.Rating.Clear();
                        currPlant.Rating.Add(0);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            PrintPlants(plants);
        }

        private static void PrintPlants(List<Plant> plants)
        {
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                int counter = 0;
                double sum = 0;
                List<double> realNums = plant.Rating.Where(x => x > 0).ToList();
                foreach (var rate in realNums)
                {
                    sum += rate;
                    counter++;
                }
                double averageRate = sum / counter;
                if (double.IsNaN(averageRate))
                {
                    averageRate = 0;
                }
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {averageRate:F2}");
            }
        }

        static List<Plant> PutPlants(int num)
        {
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                var existingPlant = plants.FirstOrDefault(x => x.Name == command[0]);
                if (existingPlant == null)
                {
                    plants.Add(new Plant() { Name = command[0], Rarity = int.Parse(command[1]) });
                }
                else
                {
                    existingPlant.Rarity = int.Parse(command[1]);
                }

            }
            return plants;
        }
    }
}
