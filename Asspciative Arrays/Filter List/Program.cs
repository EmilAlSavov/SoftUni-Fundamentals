using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}
