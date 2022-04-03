using System;
using System.Collections.Generic;

namespace Followers
{
    internal class Program
    {
        public static object Dicrionary { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, int> followers = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = command[0];

                if (commandType == "New follower")
                {
                    string username = command[1];
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, 0);
                    }
                }
                else if (commandType == "Like")
                {
                    string username = command[1];
                    int likes = int.Parse(command[2]);

                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, 0);
                    }
                    followers[username] += likes;
                }
                else if (commandType == "Comment")
                {
                    string username = command[1];

                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, 0);
                    }
                    followers[username]++;
                }
                else if (commandType == "Blocked")
                {
                    string username = command[1];
                    if (!followers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                        continue;
                    }
                    followers.Remove(username);
                }
            }
            PrintFollowers(followers);
        }
        static void PrintFollowers(Dictionary<string, int> followers)
        {
            Console.WriteLine($"{followers.Count} followers");

            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}
