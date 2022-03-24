using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Username
{
    internal class Program
    {
        public static bool Select { get; private set; }

        static void Main(string[] args)
        {
            string[] allUsernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            foreach (string username in allUsernames)
            {
                if (username.Length >= 3 && username.Length <= 16 
                    && (username.All(c => char.IsDigit(c) || char.IsLetter(c) || c == '-' || c == '_')))
                {
                    validUsernames.Add(username);
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
    }
}
