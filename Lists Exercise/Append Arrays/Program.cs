using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = String.Concat(numbers[i].Where(c => !Char.IsWhiteSpace(c)));
            }
            numbers.Reverse();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
