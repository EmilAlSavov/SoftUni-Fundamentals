using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = "";
            int moves = 0;
            List<int> wrongNumbers = new List<int>();
            while ((input = Console.ReadLine()) != "end")
            {
                moves++;
                List<int> indexes = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int index1 = indexes[0];
                int index2 = indexes[1];
                if ((index1 < 0 || index1 >= elements.Count || index1 == index2) || (index2 < 0 || index2 >= elements.Count))
                {
                    elements.Insert(elements.Count / 2, (moves * -1).ToString() + "a");
                    elements.Insert(elements.Count / 2, (moves * -1).ToString() + "a");
                    wrongNumbers.Add(moves * -1);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[index1] == elements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index2]}!");

                    if (index1 < index2)
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2 - 1);
                    }
                    else
                    {
                        elements.RemoveAt(index2);
                        elements.RemoveAt(index1 - 1);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
