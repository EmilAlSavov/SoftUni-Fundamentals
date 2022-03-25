using System;
using System.Text;

namespace The_Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder enctyptedMessage = new StringBuilder();
            enctyptedMessage.Append(Console.ReadLine());

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];

                if (commandType == "InsertSpace")
                {
                    int index = int.Parse(command[1]);

                    enctyptedMessage.Insert(index, " ");
                    Console.WriteLine(enctyptedMessage);
                } else if (commandType == "Reverse")
                {
                    string text = command[1];
                    string stringMessage = enctyptedMessage.ToString();
                    if (stringMessage.Contains(text))
                    {
                        int index = stringMessage.IndexOf(text);

                        stringMessage = stringMessage.Substring(0, index);

                        text = ReverseString(text);

                        StringBuilder sb = new StringBuilder();
                        sb.Append(stringMessage);

                        enctyptedMessage = sb;

                        enctyptedMessage.Append(text);
                        Console.WriteLine(enctyptedMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType == "ChangeAll")
                {
                    string oldString = command[1];
                    string newString = command[2];

                    enctyptedMessage.Replace(oldString, newString);
                    Console.WriteLine(enctyptedMessage);
                }
            }
            Console.WriteLine($"You have a new text message: {enctyptedMessage}");
        }
        static  string ReverseString(string text)
        {
            string result = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
    }
}
