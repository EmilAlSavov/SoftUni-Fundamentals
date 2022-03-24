using System;

namespace MIddle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string midChars = GetMIdChars(input);
            Console.WriteLine(midChars);
        }
        static string GetMIdChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                return input[input.Length / 2 - 1].ToString() + input[(input.Length / 2)].ToString();
            }
            else
            {
                return input[input.Length / 2].ToString();
            }
            }
    }
}
