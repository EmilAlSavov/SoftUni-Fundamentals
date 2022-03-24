using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> characters = Console.ReadLine().Split(' ').ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "3:1")
            {
                List<string> command = input.Split(' ').ToList();
                if (input.Contains("merge"))
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    characters = MergeList(characters, startIndex, endIndex);
                }
                else if (input.Contains("devide"))
                {
                    int index = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);
                }
            }
            Console.WriteLine(string.Join(" ", characters));
        }
        static List<string> MergeList(List<string> characters, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= characters.Count)
            {
                endIndex = characters.Count;
            }
            int index = startIndex;
            StringBuilder sb = new StringBuilder(characters[index]);
            for (int i = startIndex; i < endIndex - 1; i++)
            {
                if (startIndex >= characters.Count)
                {
                    break;
                }
                sb.Append(characters[index + 1]);
                characters.RemoveAt(index + 1);
            }
            characters.Insert(index, sb.ToString());
            return characters;
        }

        static List<string> DevideString(List<string> characters, int index, int partition)
        {
            string word = characters[index];
            List<string> result = new List<string>();
            for (int i = 0; i < partition; i++)
            {
                result.Add(word);
            }
        }
    }
}
