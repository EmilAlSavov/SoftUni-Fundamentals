using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negative_And_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers = RemoveNegativeNums(numbers);
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static List<int> RemoveNegativeNums(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
            return nums;
        }
    }
}
