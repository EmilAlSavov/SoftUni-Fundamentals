using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split().ToArray();
                if (commands.Contains("Add"))
                {
                    int num = int.Parse(commands[1]);
                    numbers.Add(num);
                }
                else if (commands.Contains("Remove"))
                {
                    int num = int.Parse(commands[1]);
                    if (num >= numbers.Count || num < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(num);
                }
                else if (commands.Contains("Insert"))
                {
                    int num = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, num);
                }
                else if (commands.Contains("left"))
                {
                    int repeats = int.Parse(commands[2]);
                    numbers = RotateLeft(numbers, repeats);
                }
                else if (commands.Contains("right"))
                {
                    int repeats = int.Parse(commands[2]);
                    numbers = RotateRight(numbers, repeats);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        static List<int> RotateLeft(List<int> numbers, int repeatTimes)
        {
            for (int i = 0; i < repeatTimes; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers[numbers.Count - 1] = numbers[0];
                for (int j = 0; j < numbers.Count - 2; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Count - 2] = lastNumber;
            }
            return numbers;
        }
        static List<int> RotateRight(List<int> numbers, int repeatTimes)
        {
            for (int i = 0; i < repeatTimes; i++)
            {
                int firstNumber = numbers[0];
                numbers[0] = numbers[numbers.Count - 1];
                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j-1];
                }
                numbers[1] = firstNumber;
            }
            return numbers;
        }
    }
}
