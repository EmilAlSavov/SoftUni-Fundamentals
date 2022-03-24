using System;

namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = "";
            int counterWonBattles = 0;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    energy -= distance;
                    counterWonBattles++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counterWonBattles} won battles and {energy} energy");
                    return;
                }

                if (counterWonBattles % 3 == 0)
                {
                    energy += counterWonBattles;
                }

            }
            Console.WriteLine($"Won battles: {counterWonBattles}. Energy left: {energy}");
        }
    }
}
