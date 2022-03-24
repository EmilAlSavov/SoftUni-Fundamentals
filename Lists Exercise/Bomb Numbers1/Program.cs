using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] specialNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNum = specialNumbers[0];
                int range = specialNumbers[1];

                int indexBomb = numbers.IndexOf(bombNum);
                if (indexBomb == 0)
                {
                    break;
                }
                int endRightIndex = indexBomb + range;
                int endLeftIndex = indexBomb - range;
                numbers = BombNumbers(numbers, indexBomb, endRightIndex, endLeftIndex);
            }
            int sum = SumList(numbers);
            Console.WriteLine(sum);
        }
        static List<int> BombNumbers(List<int> numbers, int start, int rightFinish, int leftFinish)
        {
            for (int i = start; i <= rightFinish; i++)
            {
                if (start >= numbers.Count || start < 0)
                {
                    break;
                }
                numbers.RemoveAt(start);
            }
            for (int i = start - 1; i >= leftFinish; i--)
            {
                if (i >= numbers.Count || i < 0)
                {
                    break;
                }
                numbers.RemoveAt(i);
            }
            return numbers;
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
