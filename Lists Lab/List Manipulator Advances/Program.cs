using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_List_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool areChangesMade = false;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                if (commands[0].Contains("Add"))
                {
                    numbers.Add(int.Parse(commands[1]));
                    areChangesMade = true;
                }
                else if (commands[0].Contains("RemoveAt"))
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                    areChangesMade = true;
                }
                else if (commands[0].Contains("Remove"))
                {
                    numbers.Remove(int.Parse(commands[1]));
                    areChangesMade = true;
                }
                else if (commands[0].Contains("Insert"))
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    areChangesMade = true;
                }
                else if (commands[0].Contains("Contains"))
                {
                    string result = DoesListContains(numbers, int.Parse(commands[1]));
                    Console.WriteLine(result);
                }
                else if (commands[0].Contains("PrintEven"))
                {
                    List<int> result = ReturnEven(numbers);
                    Console.WriteLine(string.Join(" ", result));
                }
                else if (commands[0].Contains("PrintOdd"))
                {
                    List<int> result = ReturnOdd(numbers);
                    Console.WriteLine(string.Join(" ", result)); 
                }
                else if (commands[0].Contains("GetSum"))
                {
                    int sum = GetSum(numbers);
                    Console.WriteLine(sum);
                }
                else if (commands[0].Contains("Filter"))
                {
                    List<int> result = Filer(numbers, commands[1], int.Parse(commands[2]));
                    Console.WriteLine(string.Join(" ", result));
                }
            }
            if (areChangesMade)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
        static string DoesListContains(List<int> list, int numberToContain)
        {
            if (list.Contains(numberToContain))
            {
                return "Yes";
            }
            else
            {
                return "No such number";
            }
        }
        static List<int> ReturnEven(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }
        static List<int> ReturnOdd(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }
        static int GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum+=numbers[i];
            }
            return sum;
        }
        static List<int> Filer(List<int> list, string conditions, int compareNumber)
        {
            List<int> result = new List<int>();
            if (conditions == "<")
            {
                foreach (int num in list)
                {
                    if (num < compareNumber)
                    {
                        result.Add(num);
                    }
                }
            }else if (conditions == ">")
            {
                foreach (int num in list)
                {
                    if (num > compareNumber)
                    {
                        result.Add(num);
                    }
                }
            } else if (conditions == ">=")
            {
                foreach (int num in list)
                {
                    if (num >= compareNumber)
                    {
                        result.Add(num);
                    }
                }
            }
            else if (conditions == "<=")
            {
                foreach (int num in list)
                {
                    if (num <= compareNumber)
                    {
                        result.Add(num);
                    }
                }
            }
            return result;
        }
    }
}
