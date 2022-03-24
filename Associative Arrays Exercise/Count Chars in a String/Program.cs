using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() != " " && !dic.ContainsKey(text[i]))
                {
                    dic.Add(text[i], 1);
                }
                else if (text[i].ToString() != " ")
                {
                    dic[text[i]]++;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
