using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<Match> matches = new List<Match>();
            double sum = 0;
            string command = "";
            Console.WriteLine("Bought furniture:");

            while ((command = Console.ReadLine()) != "Purchase")
            {
                string pattern = @"^>>(?<name>[A-Za-z]+)<<(?<price>[0-9]+\.{0,1}[0-9]{0,})!(?<quantity>\d+)";
                Regex regex = new Regex(pattern);

                Match match = regex.Match(command);

                if (regex.IsMatch(command))
                {
                    matches.Add(regex.Match(command));

                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);

                    Console.WriteLine(name);

                    sum += price * quantity;
                }
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
