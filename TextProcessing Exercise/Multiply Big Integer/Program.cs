using System;
using System.Text;
using System.Linq;

namespace Multiply_Big_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigInteger = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            int inMind = 0;

            for (int i = bigInteger.Length - 1; i >= 0; i--)
            {
                int currentNum = int.Parse(bigInteger[i].ToString());

                int sum = currentNum * multiplyer + inMind;

                int lastNum = sum % 10;
                inMind = sum / 10;

                result.Append(lastNum);
            }
            if (inMind > 0)
            {
                result.Append(inMind);
            }

            char[] chars = result.ToString().ToCharArray();
            if (chars.All(c => c == '0'))
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
