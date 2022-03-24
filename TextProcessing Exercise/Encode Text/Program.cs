using System;
using System.Text;

namespace Encode_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);

            for (int i = 0; i < sb.Length; i++)
            {
                int ascii = (int)sb[i] + 3;
                sb[i] = (char)ascii;
            }
            Console.WriteLine(sb);
        }
    }
}
