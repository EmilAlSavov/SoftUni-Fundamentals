using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                text = text.Replace(wordToRemove, "");
            }
            Console.WriteLine(text);
        }
    }
}
