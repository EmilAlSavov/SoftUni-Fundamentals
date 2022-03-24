using System;

namespace Character_Multiplyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');

            string word1 = command[0];
            string word2 = command[1];

            int result = CharacterMultiplyer(word1, word2);

            Console.WriteLine(result);
        }

        static int CharacterMultiplyer(string word1, string word2)
        {
            int sum = 0;
            if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    sum += word1[i] * word2[i];
                }
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    sum += word1[i];
                }
            }
            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    sum += word1[i] * word2[i];
                }
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    sum += word2[i];
                }
            }
            return sum;
        }
    }
}
