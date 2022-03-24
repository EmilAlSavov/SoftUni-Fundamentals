using System;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = SumVowels(input);
            Console.WriteLine(sum);

        }
        static int SumVowels(string text)
        {
            text = text.ToLower();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sum++;
                }
                else if (text[i] == 'e')
                {
                    sum++;
                }
                else if (text[i] == 'i')
                {
                    sum++;
                }
                else if (text[i] == 'o')
                {
                    sum++;
                }
                else if (text[i] == 'u')
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
