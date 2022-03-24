
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asspciative_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToList();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            for (int i = 0; i < input.Count; i++)
            {
                int keyNum = input[i];
                if (numbers.ContainsKey(keyNum))
                {
                    numbers[keyNum]++;
                }
                else
                {
                    numbers.Add(keyNum, 1);
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
