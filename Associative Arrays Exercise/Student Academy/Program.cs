using System;
using System.Collections.Generic;

namespace Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string keyName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(keyName))
                {
                    dictionary.Add(keyName, new List<double>());
                }

                dictionary[keyName].Add(grade);
            }
            
            Dictionary<string, double> readyItems = MakeNewDic(dictionary);

            foreach (var item in readyItems)
            {
                if (item.Value >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:F2}");
                }
            }
        }

        static Dictionary<string, double> MakeNewDic(Dictionary<string, List<double>> dictionary)
        {
            Dictionary<string, double> readyItems = new Dictionary<string, double>();
            foreach (var item in dictionary)
            {
                double sum = 0;

                for (int i = 0; i < item.Value.Count; i++)
                {
                    sum += item.Value[i];
                }

                readyItems.Add(item.Key, sum / item.Value.Count);
            }
            return readyItems;
        }
    }
}
