using System;
using System.Text;

namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string defaultMessage = Console.ReadLine();
            StringBuilder destinations = new StringBuilder();

            destinations.Append(defaultMessage);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string commandType = command[0];

                if (commandType == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string text = command[2];

                    destinations.Insert(index, text);
                    Console.WriteLine(destinations);
                } else if (commandType == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    destinations = Remove(destinations, startIndex, endIndex);
                    Console.WriteLine(destinations);
                }
                else if (commandType == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];

                    destinations.Replace(oldString, newString);
                    Console.WriteLine(destinations);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }

        static StringBuilder Remove(StringBuilder text,int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= text.Length || endIndex < 0 || endIndex >= text.Length)
            {
                return text;
            }
            return text.Remove(startIndex, endIndex - startIndex + 1);
        }
    }
}
