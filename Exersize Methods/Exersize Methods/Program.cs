using System;

namespace Exersize_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int minNum = GetSmallest(num1, num2, num3);
            Console.WriteLine(minNum);
        }

        static int GetSmallest(int num1, int num2, int num3)
        {
            int MaxNum = int.MaxValue;
            if (num1 < MaxNum)
            {
                MaxNum = num1;
            }if (num2 < MaxNum)
            {
                MaxNum = num2;
            }if (num3 < MaxNum)
            {
                MaxNum = num3;
            }
            return MaxNum;
        }
    }
}
