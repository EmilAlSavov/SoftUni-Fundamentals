using System;
using System.Collections.Generic;
using System.Linq;

namespace Lift_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peaple = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                if (peaple <= 0)
                {
                    break;
                }
                if (lift[i] >= 4)
                {
                    continue;
                }
                peaple--;
                lift[i]++;
                i--;
            }
            if (peaple == 0 && lift[lift.Count - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }else if (lift[lift.Count - 1] == 4 && peaple > 0)
            {
                Console.WriteLine($"There isn't enough space! {peaple} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
