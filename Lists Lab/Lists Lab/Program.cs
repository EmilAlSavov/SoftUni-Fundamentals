using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double originaCount = list.Count;
            int index = 1;
            for (double i = 0; i <= originaCount; i++)
            {
                if (index <= 0)
                {
                    index++;
                }
                if (index >= list.Count)
                {
                    break;
                }
                if (list[index] == list[index-1])
                {
                    double sum = list[index] + list[index - 1];
                    list.RemoveAt(index -1);
                    list.RemoveAt(index - 1);
                    list.Insert(index - 1, sum);
                    index-=2;
                }
                index++;
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
