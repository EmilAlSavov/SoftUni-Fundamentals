using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxPassengers = int.Parse(Console.ReadLine());
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split(' ').ToList();
                if (input.Contains("Add"))
                {
                    int passangers = int.Parse(commands[1]);
                    wagons.Add(passangers);
                }
                else
                {
                    int passangers = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + passangers) <= maxPassengers)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
