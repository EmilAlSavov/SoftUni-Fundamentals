using System;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string field = Console.ReadLine();
            int bombPower = 0;

            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == '>')
                {
                    int currentBombPower = int.Parse(field[i+1].ToString());
                    bombPower += currentBombPower;
                } else if (bombPower > 0 && field[i] != '>')
                {
                    field = field.Remove(i, 1);
                    bombPower--;
                    i--;
                }
            }

            Console.WriteLine(field);
        }
    }
}
