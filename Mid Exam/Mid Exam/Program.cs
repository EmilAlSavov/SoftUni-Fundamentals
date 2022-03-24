using System;

namespace Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expNeeded = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            double expCount = 0;

            for (int i = 1; i <= battles; i++)
            {
                double currentExp = double.Parse(Console.ReadLine());

                if (i % 15 == 0 && i > 0)
                {
                    currentExp += currentExp * 0.05;
                }
                if (i % 3 == 0 && i > 0)
                {
                    currentExp += currentExp * 0.15;
                }
                if (i % 5 == 0 && i > 0)
                {
                    currentExp -= currentExp * 0.1;
                }

                expCount += currentExp;

                if (expCount >= expNeeded)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {(expNeeded - expCount):F2} more needed.");
        }
    }
}
