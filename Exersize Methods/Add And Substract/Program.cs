using System;

namespace Add_And_Substract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = AddAndSubstract(num, num2, num3);
            Console.WriteLine(result);
        }
        static int AddAndSubstract(int num, int num2, int num3)
        {
                 return (num + num2) - num3;
        }
    }
}
