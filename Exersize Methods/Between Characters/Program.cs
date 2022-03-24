using System;

namespace Between_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            if (char1 > char2)
            {
                PrintChars(char2, char1);
            }
            else
            {
                PrintChars(char1, char2);
            }
        }
        static void PrintChars(char start, char finish)
        {
            for (int i = start + 1; i < finish; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}
