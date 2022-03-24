using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([#|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<cal>\d{1,5})\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            int calSum = 0;
            foreach (Match match in matches)
            {
                int cal = int.Parse(match.Groups["cal"].Value);
                calSum += cal;
            }
            Console.WriteLine($"You have food to last you for: {calSum / 2000} days!");

            foreach(Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string expirationDate = match.Groups["date"].Value;
                string calString = match.Groups["cal"].Value;

                Console.WriteLine($"Item: {name}, Best before: {expirationDate}, Nutrition: {calString}");
            }
        }
    }
}
