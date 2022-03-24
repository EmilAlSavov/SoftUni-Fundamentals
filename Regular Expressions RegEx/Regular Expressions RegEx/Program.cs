using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{2,})\b";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
