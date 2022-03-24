using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> destinations = new List<string>();
            string text = Console.ReadLine();

            string pattern = @"([=\/])(?<name>[A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            int sum = 0;
            foreach(Match match in matches)
            {
                string currentLocation = match.Groups["name"].Value;

                destinations.Add(currentLocation);
                sum+=currentLocation.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
