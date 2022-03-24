using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();
                string name = commands[0];
                if (!commands.Contains("not"))
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guests.Add(name);
                }
                else
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guests.Remove(name);
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, guests));
        }
    }
}
