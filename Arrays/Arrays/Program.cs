using System;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Print Days Of The Week
            //int num = int.Parse(Console.ReadLine());
            //string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //if (num > 0 && num < 8)
            //{
            //    Console.WriteLine(daysOfTheWeek[num - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}

            ///Reverse Array
            //int n = int.Parse(Console.ReadLine());
            //int[] items = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    items[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(items);
            //Console.WriteLine(String.Join(' ', items));

            ///Round Array
            //string[] rawArray = Console.ReadLine().Split(' ');
            //double[] items = new double[rawArray.Length];
            //for (int i = 0; i < rawArray.Length; i++)
            //{
            //        items[i] = double.Parse(rawArray[i]);
            //    if (items[i] == -0)
            //    {
            //        items[i] = 0;
            //    }
            //}

            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            //}

            ///Reverse String Array
            //string[] items = Console.ReadLine().Split(' ');
            //Array.Reverse(items);
            //Console.WriteLine(string.Join(' ', items));

            ///Sum Even Numbers
            //int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int sum = 0;
            //for (int i = 0; i < items.Length; i++)
            //{
            //    if (items[i] % 2 == 0)
            //    {
            //        sum += items[i];
            //    }
            //}
            //Console.WriteLine(sum);

            ///Difference Between Even And Odd Numbers
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int sum1 = 0;
            //int sum2 = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int currentNum = numbers[i];
            //    if (currentNum % 2 == 0)
            //    {
            //        sum1 += currentNum;
            //    }
            //    else
            //    {
            //        sum2 += currentNum;
            //    }
            //}
            //Console.WriteLine(sum1 - sum2);

            ///Equal Arrays
            //int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int sum = 0;
            //int index = 0;
            //int counter = 0;
            //bool notEqual = false;

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    int currentNum1 = array1[i];
            //    int currentNum2 = array2[i];
            //    if (currentNum1 == currentNum2)
            //    {
            //        sum += currentNum1;
            //    }
            //    else
            //    {
            //        if (counter < 1)
            //        {
            //            index = i;
            //        }
            //        counter++;
            //        notEqual = true;
            //    }

            //}
            //if (!notEqual)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            //}

            ///Condense Array To Number
            //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int firstLenght = nums.Length;
            //for (int i = 0; i < firstLenght - 1; i++)
            //{
            //int[] condensed = new int[nums.Length - 1];
            //    for (int j = 0; j < nums.Length-1; j++)
            //    {
            //        condensed[j] = nums[j] + nums[j + 1];
            //    }
            //    nums = condensed;
            //}
            //Console.WriteLine(nums[0]);
        }
    }
}
