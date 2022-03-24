using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOfEven = GetSumOfEvenDigits(num);
            int sumOfOdd = GetSumOfOddDigits(num);

            int result = GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdd);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int num)
        {
            int startLength = num.ToString().Length;
            int sum = 0;
            for (int i = 0; i < startLength; i++)
            {
                int currentNum = num % 10;
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
                num = num / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int startLength = num.ToString().Length;
            int sum = 0;
            for (int i = 0; i < startLength; i++)
            {
                int currentNum = num % 10;
                if (currentNum % 2 != 0)
                {
                    sum += currentNum;
                }
                num = num / 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int a, int b)
        {
            return a * b;
        }
    }
}
