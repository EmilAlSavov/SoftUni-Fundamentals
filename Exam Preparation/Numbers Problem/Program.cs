using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum+=numbers[i];
            }

            int averageNumber = sum/numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNumber)
                {
                    result.Add(numbers[i]);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            result.Sort();
            result.Reverse();

            for (int i = 0; i < result.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                if (i == result.Count - 1 || i == 4)
                {
                    Console.WriteLine(result[i]);
                    break;
                }
                Console.Write(result[i] + " ");
            }
        }
    }
}
