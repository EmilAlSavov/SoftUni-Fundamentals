using System;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            string finalString = "";
            foreach (var word in text)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    finalString += word;
                }
            }
            Console.WriteLine(finalString);
        }
    }
}
