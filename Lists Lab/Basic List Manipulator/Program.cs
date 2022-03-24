using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_List_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                if (commands[0].Contains("Add"))
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (commands[0].Contains("RemoveAt"))
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0].Contains("Remove"))
                {
                    numbers.Remove(int.Parse(commands[1]));
                }
                else if (commands[0].Contains("Insert"))
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
