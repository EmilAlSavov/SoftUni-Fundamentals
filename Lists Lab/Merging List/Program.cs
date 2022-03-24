using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(list.Count, list2.Count); i++)
            {
               result.Add(list[i]);
               result.Add(list2[i]);
            }
            if (list.Count > list2.Count)
            {
                for (int i = list2.Count; i < list.Count; i++)
                {
                    result.Add(list[i]);
                }
            }
            else if (list2.Count > list.Count)
            {
                for (int i = list.Count; i < list2.Count; i++)
                {
                    result.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
