using System;

namespace Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string readyText = string.Empty;

            readyText += text[0];
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    continue;
                }
                readyText += text[i];
            }
            Console.WriteLine(readyText);
        }
    }
}
