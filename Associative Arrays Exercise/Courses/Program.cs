using System;
using System.Collections.Generic;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ");
                
                string courseName = command[0];
                string studentName = command[1];

                if (!dictionary.ContainsKey(courseName))
                {
                    dictionary.Add(courseName, new List<string>());
                }

                dictionary[courseName].Add(studentName);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
