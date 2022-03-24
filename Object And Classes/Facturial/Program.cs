using System;
using System.Numerics;

namespace Facturial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger num = 1;

            for (int i = 1; i < n; i++)
            {
                num += num * i;
            }
            Console.WriteLine(num);
        }
    }
}
