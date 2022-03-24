using System;

namespace Object_And_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);
                string word = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
