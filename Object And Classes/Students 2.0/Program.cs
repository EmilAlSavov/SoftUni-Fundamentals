using System;
using System.Collections.Generic;

namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (DoesStudentExist(students, command[0], command[1]))
                {
                    Student student = GetStudentExist(students, command[0], command[1]);
                    student.Age = int.Parse(command[2]);
                    student.HomeTown = command[3];
                    continue;
                }

                Student newStudent = new Student() { FirstName = command[0], LastName = command[1], Age = int.Parse(command[2]), HomeTown = command[3] };
                students.Add(newStudent);
            }
            string town = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].HomeTown == town)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
           foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
           return false;
        }
        static Student GetStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
