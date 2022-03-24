using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Racer
    {
        public string Name{ get; set; }

        public int distance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Racer> racers = new List<Racer>();

            string[] listRacers = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < listRacers.Length; i++)
            {
                racers.Add(new Racer { Name = listRacers[i], distance = 0 });
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of the race")
            {

                Regex getName = new Regex("[A-Za-z]");
                Regex getDistance = new Regex(@"\d");

                if (getName.IsMatch(command))
                {
                    int sum = 0;

                    foreach (Match item in getDistance.Matches(command))
                    {
                        sum += int.Parse(item.Value);
                    
                    }
                    Match nameMatch = getName.Match(command);

                    racers.Any(x => x.Name == nameMatch.Value
                    {
                        racers.C(x => x.Name == nameMatch.Value, x.distance = sum)
                    }
                }
            }
        }
    }
}
