using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < deck1.Count; i++)
            {
                if (deck1.Count <= 0 || deck2.Count <=0)
                {
                    break;
                }
                if (deck1[i] > deck2[i])
                {
                    deck1.Add(deck1[i]);
                    deck1.Add(deck2[i]);
                    deck1.RemoveAt(i);
                    deck2.RemoveAt(i);
                    i--;
                }
                else if (deck2[i] > deck1[i])
                {
                    deck2.Add(deck2[i]);
                    deck2.Add(deck1[i]);
                    deck2.RemoveAt(i);
                    deck1.RemoveAt(i);
                    i--;
                }
                else
                {
                    deck1.RemoveAt(i);
                    deck2.RemoveAt(i);
                    i--;
                }
            }
            if (deck1.Count > deck2.Count)
            {
                int sum = SumList(deck1);
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (deck1.Count < deck2.Count)
            {
                int sum = SumList(deck2);
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
        
        static int SumList(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
