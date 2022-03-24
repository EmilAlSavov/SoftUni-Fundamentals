using System;
using System.Text;

namespace The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] command = input.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string typeOfCommand = command[0];

                if (typeOfCommand == "Move")
                {
                    int numberOfTymes = int.Parse(command[1]);
                    message = MoveString(message, numberOfTymes);
                }
                else if (typeOfCommand == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    message = message.Insert(index, value);
                }
                else if (typeOfCommand == "ChangeAll")
                {
                    string value = command[1];
                    string changeString = command[2];

                    message = message.Replace(value, changeString);
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string MoveString(string message, int numberOfTymes)
        {
            StringBuilder result = new StringBuilder();
            result.Append(message);

            for (int i = 0; i < numberOfTymes; i++)
            {
                char firstLetter = result[0];
                for (int j = 1; j < message.Length; j++)
                {
                    result[j-1] = result[j];
                }
                result[result.Length - 1] = firstLetter;
            }
            return result.ToString();
        }
    }
}
