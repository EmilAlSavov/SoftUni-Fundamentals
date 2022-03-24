using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    internal class Program
    {
        class Students
        {
            public string FirstNane{ get; set; }
            public string LastNane { get; set;}
            public double Grade{ get; set; }

            public override string ToString()
            {
                return $"{this.FirstNane} {this.LastNane}: {this.Grade:F2}";
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                string firstName = command[0];
                string lastName = command[1];
                double grade = double.Parse(command[2]);

                Students newStudent = new Students() { FirstNane = firstName, LastNane = lastName, Grade = grade };

                students.Add(newStudent);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
