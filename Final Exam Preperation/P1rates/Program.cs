using System;
using System.Collections.Generic;
using System.Linq;

namespace P1rates
{
    class Town
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Town> targetTowns = AddTowns();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string typeOfCommand = command[0];

                if (typeOfCommand == "Plunder")
                {
                    string townName = command[1];
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);

                    Town currTown = targetTowns.FirstOrDefault(x => x.Name == townName);

                    if (currTown != null)
                    {
                        currTown.Population -= people;
                        currTown.Gold -= gold;

                        Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (currTown.Gold <= 0 || currTown.Population <= 0)
                        {
                            Console.WriteLine($"{townName} has been wiped off the map!");
                            targetTowns.Remove(currTown);
                            continue;
                        }
                    }
                }
                else if (typeOfCommand == "Prosper")
                {
                    string townName = command[1];
                    int gold = int.Parse(command[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    Town currTown = targetTowns.FirstOrDefault(x => x.Name == townName);

                    if (currTown != null)
                    {
                        currTown.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {currTown.Gold} gold.");
                    }
                }
            }

            PrintTowns(targetTowns);

        }

        static List<Town> AddTowns()
        {
            List<Town> targetTowns = new List<Town>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] command = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string townName = command[0];
                int population = int.Parse(command[1]);
                int gold = int.Parse(command[2]);

                if (targetTowns.Any(x => x.Name == townName))
                {
                    Town currentTown = targetTowns.FirstOrDefault(x => x.Name == townName);

                    currentTown.Population += population;
                    currentTown.Gold += gold;
                }
                else
                {
                    targetTowns.Add(new Town() { Name = townName, Population = population, Gold = gold });
                }
            }
            return targetTowns;
        }

        static void PrintTowns(List<Town> towns)
        {
            if (towns.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");

            foreach (Town town in towns)
            {
                Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
            }
        }
    }
}
