using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffe_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command.Contains("Include"))
                {
                    coffees.Add(command[1]);
                }
                else if (command.Contains("Remove"))
                {
                    string type = command[1];
                    int numToRemove = int.Parse(command[2]);
                    coffees = Remove(coffees, type, numToRemove);
                }
                else if (command.Contains("Prefer"))
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    coffees = Change(coffees, index1, index2);
                }
                else if (command.Contains("Reverse"))
                {
                    coffees.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }

        static List<string> Remove(List<string> coffees, string type, int numToRemove)
        {
            if (numToRemove >= coffees.Count || numToRemove < 0)
            {
                return coffees;
            }

            if (type == "first")
            {
                coffees = RemoveFirst(coffees, numToRemove);
                return coffees;
            }
            else
            {
                coffees = RemoveLast(coffees, numToRemove);
                return coffees;
            }
        }

        static List<string> Change(List<string> coffees, int index1, int index2)
        {
            if (index1 < 0 || index1 >= coffees.Count || index2 < 0 || index2 >= coffees.Count)
            {
                return coffees;
            }

            string firstIndexValue = coffees[index1];
            coffees[index1] = coffees[index2];
            coffees[index2] = firstIndexValue;

            return coffees;
        }

        static List<string> RemoveFirst(List<string> coffees, int numToRemove)
        {
            for (int i = 0; i < numToRemove; i++)
            {
                coffees.RemoveAt(0);
            }
            return coffees;
        }

        static List<string> RemoveLast(List<string> coffees, int numToRemove)
        {
            for (int i = 0; i < numToRemove; i++)
            {
                coffees.RemoveAt(coffees.Count - 1);
            }
            return coffees;
        }
    }
}
