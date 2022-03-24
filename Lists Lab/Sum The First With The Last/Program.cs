using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_The_First_With_The_Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (list.Count % 2 != 0)
            {
                int mid = list[list.Count / 2];
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] += list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                }
                Console.WriteLine(String.Join(" ", list) + " " + mid);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] += list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                }
                Console.WriteLine(String.Join(" ", list));
            }

            
        }
    }
}
