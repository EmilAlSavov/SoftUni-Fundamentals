using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Targets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commands = input.Split().ToList();

                if (commands.Contains("Shoot"))
                {
                    int index = int.Parse(commands[1]);
                    int power = int.Parse(commands[2]);
                    targets = ShootTarget(targets, index, power);
                }
                else if (commands.Contains("Add"))
                {
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);
                    targets = AddTarget(targets, index, value);
                }
                else if (commands.Contains("Strike"))
                {
                    int index = int.Parse(commands[1]);
                    int radius = int.Parse(commands[2]);
                    targets = StrikeTarget(targets, index, radius);
                }
            }
            Console.WriteLine(String.Join("|", targets));
        }

        static List<int> ShootTarget(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
            return targets;
        }

        static List<int> AddTarget(List<int> targets, int index, int value)
        {
            if (index < 0 || index >= targets.Count)
            {
                Console.WriteLine("Invalid placement!");
                return targets;
            }
            targets.Insert(index, value);
            return targets;
        }

        static List<int> StrikeTarget(List<int> targets, int index, int radius)
        {
            if (index < 0 || index >= targets.Count 
                || index + radius < 0 || index + radius >= targets.Count 
                || index - radius < 0 || index - radius >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return targets;
            }

            for (int i = index; i <= index + radius; i++)
            {
                targets.RemoveAt(index);
            }
            for (int i = index - 1; i >= index - radius; i--)
            {
                targets.RemoveAt(index - 1);
            }
            return targets;
        }
    }
}
