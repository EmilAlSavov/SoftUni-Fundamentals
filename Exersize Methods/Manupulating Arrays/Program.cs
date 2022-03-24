using System;
using System.Linq;

namespace Manupulating_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).Select(Math.Abs).ToArray();
            string input = "";
            while ((input = Console.ReadLine())!= "end")
            {
                if (input.Contains("exchange"))
                {
                    string[] arrInput = input.Split().ToArray();
                    int splitIndex = int.Parse(arrInput[1]);
                    ExchangeArray(ref array, splitIndex);
                }
                if (input.Contains("max"))
                {
                    string[] arrInput = input.Split().ToArray();
                    string type = arrInput[1];
                    MaxEvenOrOdd(array, type);
                }
                if (input.Contains("min"))
                {
                    string[] arrInput = input.Split().ToArray();
                    string type = arrInput[1];
                    MinEvenOrOdd(array, type);
                }
                if (input.Contains("first"))
                {
                    string[] arrInput = input.Split().ToArray();
                    int howManyDigits = int.Parse(arrInput[1]);
                    string evenOrOdd = arrInput[2];
                    FirstEvenOrOdd(array, howManyDigits, evenOrOdd);
                }
                if (input.Contains("last"))
                {
                    string[] arrInput = input.Split().ToArray();
                    int howManyDigits = int.Parse(arrInput[1]);
                    string evenOrOdd = arrInput[2];
                    LastEvenOrOdd(array, howManyDigits, evenOrOdd);
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        static void ExchangeArray(ref int[] array, int splitIndex)
        {
            int[] array1 = new int[array.Length];
            int  index1 = splitIndex + 1;
            if (splitIndex >= array.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            if (splitIndex >= array.Length-1)
            {
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[index1];
                if (index1 == array.Length - 1)
                {
                    index1 = 0;
                }
                else
                {
                index1++;
                }
            }
            array = array1;
        }
        static void MaxEvenOrOdd(int[] array, string type)
        {
            int MinValue = int.MinValue;
            int biggestIndex = 0;
            if (type == "odd")
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] >= MinValue)
                        {
                            MinValue = array[i];
                            biggestIndex = i;
                            counter++;
                        }
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine(biggestIndex);
                    return;
                }

            }
            else if (type == "even")
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] >= MinValue)
                        {
                            MinValue = array[i];
                            biggestIndex = i;
                            counter++;
                        }
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine(biggestIndex);
                    return;
                }
            }
            Console.WriteLine("No matches");
            return;
        }
        static void MinEvenOrOdd(int[] array, string type)
        {
            int MaxValue = int.MaxValue;
            int smallestIndex = 0;
            if (type == "odd")
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] <= MaxValue)
                        {
                            MaxValue = array[i];
                            smallestIndex = i;
                            counter++;
                        }
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine(smallestIndex);
                    return;
                }
            }
            else if (type == "even")
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] <= MaxValue)
                        {
                            MaxValue = array[i];
                            smallestIndex = i;
                            counter++;
                        }
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine(smallestIndex);
                    return;
                }
            }
            Console.WriteLine("No matches");
            return;
        }

        static void FirstEvenOrOdd(int[] array, int howManyDigits, string evenOrOdd)
        {
            int evenNumbers = 0;
            int oddNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }
            }
            
            int index = 0;
            if (howManyDigits > array.Length || howManyDigits < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (evenOrOdd == "even")
            {
                if (howManyDigits > evenNumbers)
                {
                    howManyDigits = evenNumbers;
                }
                int[] result = new int[howManyDigits];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        result[index] = array[i];
                        index++;
                    }
                    if (index == howManyDigits)
                    {
                        break;
                    }
                }
                if (index > 0)
                {
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                    return;
                }
            }
            else if (evenOrOdd == "odd")
            {
                if (howManyDigits > oddNumbers)
                {
                    howManyDigits = oddNumbers;
                }
                int[] result = new int[howManyDigits];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        result[index] = array[i];
                        index++;
                    }
                    if (index == howManyDigits)
                    {
                        break;
                    }
                }
                if (index > 0)
                {
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                    return;
                }
            }
            Console.WriteLine("[]");
        }
        static void LastEvenOrOdd(int[] array, int howManyDigits, string evenOrOdd)
         {
            int evenNumbers = 0;
            int oddNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }
            }

            int index = 0;
            if (howManyDigits > array.Length || howManyDigits < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (evenOrOdd == "even")
            {
                if (howManyDigits > evenNumbers)
                {
                    howManyDigits = evenNumbers;
                }
                int[] result = new int[howManyDigits];

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        result[index] = array[i];
                        index++;
                    }
                    if (index == howManyDigits)
                    {
                        break;
                    }
                }
                if (index > 0)
                {
                    Array.Reverse(result);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                    return;
                }
            }
            else if (evenOrOdd == "odd")
            {
                if (howManyDigits > oddNumbers)
                {
                    howManyDigits = oddNumbers;
                }
                int[] result = new int[howManyDigits];

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        result[index] = array[i];
                        index++;
                    }
                    if (index == howManyDigits)
                    {
                        break;
                    }
                }
                if (index > 0)
                {
                    Array.Reverse(result);
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                    return;
                }
            }
            Console.WriteLine("[]");
        }

    }
}
