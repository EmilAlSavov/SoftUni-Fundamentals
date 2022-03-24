using System;
using System.Collections.Generic;
using System.Linq;

namespace Register_ID
{
    class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }

        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(' ');

                string name = info[0];
                int id = int.Parse(info[1]);
                int age = int.Parse(info[2]);

                if (people.Any(p => p.ID == id))
                {
                    Person person = people.FirstOrDefault(p => p.ID == id);
                    person.Name = name;
                }
                else
                {
                    Person person = new Person(name, id, age);
                    people.Add(person);
                }
            }
            PrintPeople(people);
        }

        static void PrintPeople(List<Person> people)
        {
            people = people.OrderBy(p => p.Age).ToList();

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{people[i].Name} with ID: {people[i].ID} is {people[i].Age} years old.");
            }
        }
    }
}
