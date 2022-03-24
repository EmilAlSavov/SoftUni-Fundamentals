using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                if (commands.Contains("Delete"))
                {
                    int element = int.Parse(commands[1]);
                    numbers = DeleteFromList(numbers, element);
                }
                else if (commands.Contains("Insert"))
                {
                    int position = int.Parse(commands[2]);
                    int element = int.Parse(commands[1]);
                    numbers.Insert(position, element);
                }
            }
                Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> DeleteFromList(List<int> numbers, int element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.Remove(element);
            }
            return numbers;
        }
    }
}
