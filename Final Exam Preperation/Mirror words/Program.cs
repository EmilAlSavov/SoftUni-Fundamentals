using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Mirror_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();
            string input = Console.ReadLine();

            string pattern = @"([@#])(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            if (!regex.IsMatch(input))
            {
                Console.WriteLine("No word pairs found!");
                return;
            }

            Console.WriteLine($"{matches.Count} word pairs found!");

            foreach(Match match in matches)
            {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;

               string reversedWord = ReverseString(word1);

                if (reversedWord == word2)
                {
                    mirrorWords.Add(word1, word2);
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }

            Console.WriteLine("The mirror words are:");

            int counter = 0;
            foreach (var mirrorWord in mirrorWords)
            {
                if (counter == 0)
                {
                    Console.Write($"{ mirrorWord.Key} <=> { mirrorWord.Value}");
                }
                else
                {
                    Console.Write($", {mirrorWord.Key} <=> {mirrorWord.Value}");
                }
                    counter++;
            }
            Console.WriteLine();
        }
        static string ReverseString(string text)
        {
            string result = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
    }
}
