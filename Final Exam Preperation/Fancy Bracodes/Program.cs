using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Fancy_Bracodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                string pattern = @"^@[#]+(?<product>[A-Z]([A-Za-z\d]){4,}[A-Z])@[#]+$";
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(barcode))
                {
                    string currentGroup = ConcatinateDigits(barcode);

                    Console.WriteLine($"Product group: {currentGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        static string ConcatinateDigits(string text)
        {
            string result = "00";
            bool haveDigit = false;
            foreach (char character in text)
            {
                if (Char.IsDigit(character))
                {
                    if (!haveDigit)
                    {
                        result = "";
                    }
                    result += character;
                    haveDigit = true;
                }
            }
            return result;
        }
    }
}
