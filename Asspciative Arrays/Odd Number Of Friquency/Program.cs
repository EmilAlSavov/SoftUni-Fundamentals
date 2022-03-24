using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Number_Of_Friquency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split().Select(x => x.ToLower()).ToList();
            Dictionary<string, int> friquency = new Dictionary<string, int>();

            for (int i = 0; i < items.Count; i++)
            {
                if (!friquency.ContainsKey(items[i]))
                {
                    friquency.Add(items[i], 0);
                }
                friquency[items[i]]++;
            }

            foreach (var item in friquency)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
