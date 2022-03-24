using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWork_Project
{
    class Teams
    {
        public Teams(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Members = new List<string>();
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }

        public string TeamName { get; set; }

        public int Count { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{TeamName}, {Count}, {string.Join(", ", Members)}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> creators = new List<string>();
            List<string> teamNames = new List<string>();
            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();

                string creator = command[0];
                string teamName = command[1];

                if (creators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                if (teamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                Teams newTeam = new Teams(teamName, creator);

                newTeam.Members.Add(creator);
                newTeam.Count = newTeam.Members.Count;
                teams.Add(newTeam);
                creators.Add(creator);
                teamNames.Add(teamName);
            }

            string input = "";

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                List<string> command = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();

                string memberName = command[0];
                string teamName = command[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Teams team = teams.FirstOrDefault(t => t.TeamName == teamName);

                    if (teams.Any(t => t.Members.Contains(memberName)))
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {team.TeamName}!");
                        continue;
                    }

                    team.Members.Add(memberName);
                    team.Count = team.Members.Count;
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }
            PrintTeams(teams);
        }

        static void PrintTeams(List<Teams> teams)
        {
            teams = teams.OrderByDescending(t => t.Count).ThenBy(t => t.TeamName).ToList();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Count > 1)
                {
                    Console.WriteLine(teams[i].TeamName);
                    Console.WriteLine($"- {teams[i].Members[0]}");
                    teams[i].Members.RemoveAt(0);
                    for (int y = 0; y < teams[i].Members.Count; y++)
                    {
                        teams[i].Members.Sort();
                        Console.WriteLine($"-- {teams[i].Members[y]}");
                    }
                }
                
            }
            Console.WriteLine("Teams to disband:");
            teams = teams.OrderBy(t => t.TeamName).ToList();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Count <= 1)
                {
                    Console.WriteLine(teams[i].TeamName);
                }
            }
        }
    }
}
