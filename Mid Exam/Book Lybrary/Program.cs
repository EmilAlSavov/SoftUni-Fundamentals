
using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Lybrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "Done")
            {
                List<string> commands = input.Split('|').ToList();
                commands = TrimCommands(commands);
                if (commands.Contains("Add Book"))
                {
                    string book = commands[1];
                    if (CheckIfBookIsInLybrary(books, book))
                    {
                        continue;
                    }
                    books.Reverse();
                    books.Add(book);
                    books.Reverse();
                }
                else if (commands.Contains("Take Book"))
                {
                    String book = commands[1];
                    books.Remove(book);
                }
                else if (commands.Contains("Swap Books"))
                {
                    string book1 =commands[1];
                    string book2 = commands[2];
                    books = SwapBooks(books, book1, book2);
                }
                else if (commands.Contains("Insert Book"))
                {
                    string book = commands[1];
                    if (CheckIfBookIsInLybrary(books, book))
                    {
                        continue;
                    }
                    books.Add(book);
                }
                else if (commands.Contains("Check Book"))
                {
                    int index = int.Parse(commands[1]);
                    PrintBook(books, index);
                }
            }
            Console.WriteLine(string.Join(", ", books));
        }

        static bool CheckIfBookIsInLybrary(List<string> books, string bookToCheck)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i] == bookToCheck)
                {
                    return true;
                }
            }
            return false;
        }

        static List<string> TrimCommands (List<string> commands)
        {
            for (int i = 0; i < commands.Count; i++)
            {
               commands[i] = commands[i].Trim(' ');
            }
            return commands;
        }

        static List<string> SwapBooks(List<string> books, string book1, string book2)
        {
            if (!CheckIfBookIsInLybrary(books, book1) || !CheckIfBookIsInLybrary(books, book2))
            {
                return books;
            }

            int index1 = books.IndexOf(book1);
            int index2 = books.IndexOf(book2);

            string firstBook = books[index1];
            books[index1] = books[index2];
            books[index2] = firstBook;
            return books;
        }

        static void PrintBook(List<string> books, int index)
        {
            if (index < 0 || index >= books.Count)
            {
                return;
            }
            Console.WriteLine(books[index]);
        }
    }
}
