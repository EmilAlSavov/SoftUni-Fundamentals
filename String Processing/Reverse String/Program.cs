using System;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string word = command;

                string reversedWord = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}
