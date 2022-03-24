using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
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
                string type = commands[0];
                if (type == "swap")
                {
                    numbers = Swap(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                } else if (type == "multiply")
                {
                    numbers[int.Parse(commands[1])] = numbers[int.Parse(commands[2])] * numbers[int.Parse(commands[1])];
                } else if (type == "decrease")
                {
                    numbers = Decrease(numbers);
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
        static List<int> Swap(List<int> numbers, int index1, int index2)
        {
            int firstNum = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = firstNum;
            return numbers;
        }
        static List<int> Decrease(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
            return numbers;
        }
    }
}
