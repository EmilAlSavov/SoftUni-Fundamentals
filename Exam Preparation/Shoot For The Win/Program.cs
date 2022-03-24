using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_For_The_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = "";
            int counter = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int indexToShoot = int.Parse(command);
                if (indexToShoot < 0 || indexToShoot >= targets.Count || indexToShoot == -1)
                {
                    continue;
                }
                targets = ReduceAndIncrease(targets, indexToShoot);
                counter++;
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
        static List<int> ReduceAndIncrease(List<int> targets, int indexToShoot)
        {
            int value = targets[indexToShoot];
                targets[indexToShoot] = -1;
            for (int i = 0; i < targets.Count; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }

                if (value < targets[i])
                {
                    targets[i] -= value;
                }
                else
                {
                    targets[i] += value;
                }
            }
            return targets;
        }
    }
}
