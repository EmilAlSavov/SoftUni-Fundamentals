using System;

namespace Math_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '/':
                    Devide(num1, num2);
                    break;
                case '*':
                    Multiply(num1, num2);
                    break ;
                case '+':
                    Add(num1, num2);
                    break;
                case '-':
                    Substract(num1, num2);
                    break;
            }
        }
        static void Add(double num, double num2)
        {
            Console.WriteLine(num + num2);
        }
        static void Multiply(double num, double num2)
        {
            Console.WriteLine(num * num2);
        }
        static void Substract(double num, double num2)
        {
            Console.WriteLine(num - num2);
        }
        static void Devide(double num, double num2)
        {
            Console.WriteLine(num / num2);
        }
    }
}
