using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Easter_Eggs
{
    class Eggs
    {
        public string Color { get; set; }

        public int Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Eggs> eggs = new List<Eggs>();
            string text = Console.ReadLine();

            string pattern = @"[#@]+(?<color>[a-z]{3,})[#@]+(\W+)*[\/]+(?<quantity>\d+)[\/]+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string color = match.Groups["color"].Value;
                int quantiry = int.Parse(match.Groups["quantity"].Value);

                eggs.Add(new Eggs() { Color = color, Quantity = quantiry });
            }

            foreach (var item in eggs)
            {
                Console.WriteLine($"You found {item.Quantity} {item.Color} eggs!");
            }
        }
    }
}
