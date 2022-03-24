using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string command = "";
            int counter = 0;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] array = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                string[] DNAs = new string[counter + 1];
                DNAs[counter] = string.Join(" ", array);
                counter++;
            }
        }
        static void GetSubsequens(int[] array, int size)
        {
            for (int i = 0; i < array.Length; i++)
            {

            }
        }
    }
}
