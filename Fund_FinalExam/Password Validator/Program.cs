using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            StringBuilder pass = new StringBuilder();

            pass.Append(password);

            if (true)
            {
                string input = string.Empty;

                while ((input = Console.ReadLine()) != "Complete")
                {
                    string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string commandType = command[0];

                    if (commandType == "Make")
                    {
                        string upperOrLower = command[1];
                        int index = int.Parse(command[2]);

                        if (upperOrLower == "Upper")
                        {
                            string upperchar = pass[index].ToString().ToUpper();
                            pass = pass.Remove(index, 1);
                            pass.Insert(index, upperchar);
                            Console.WriteLine(pass);
                        }
                        else if (upperOrLower == "Lower")
                        {
                            string lowerchar = pass[index].ToString().ToLower();
                            pass = pass.Remove(index, 1);
                            pass.Insert(index, lowerchar);
                            Console.WriteLine(pass);
                        }
                    }
                    else if (commandType == "Insert")
                    {
                        int index = int.Parse(command[1]);
                        char character = char.Parse(command[2]);
                        if (!isIndexValid(pass, index))
                        {
                            continue;
                        }
                        pass.Insert(index, character);
                        Console.WriteLine(pass);
                    }
                    else if (commandType == "Replace")
                    {
                        char character = char.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        if (!pass.ToString().Contains(character))
                        {
                            continue;
                        }

                        int ascii = (int)character;
                        int newAscii = ascii + value;
                        char newChar = (char)newAscii;
                        pass.Replace(character, newChar);
                        Console.WriteLine(pass);
                    }
                    else if (commandType == "Validation")
                    {
                        ValidatePass(pass);
                    }
                }
            }
        }

        static void ValidatePass(StringBuilder password)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }
            Regex regex = new Regex(@"\w+");

            if (!regex.IsMatch(password.ToString()))
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
            }
            bool isThereAChar = false;
            bool isThereADigit = false;
            bool isThereAUpperChar = false;
            foreach (char character in password.ToString())
            {
                if (char.IsLower(character))
                {
                    isThereAChar = true;
                }
                else if (char.IsUpper(character))
                {
                    isThereAUpperChar = true;
                }
                else if (char.IsDigit(character))
                {
                    isThereADigit = true;
                }
            }

            if (isThereAUpperChar == false)
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }
            if (isThereAChar == false)
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }
            if (isThereADigit == false)
            {
                Console.WriteLine("Password must consist at least one digit!");
            }
        }

        static bool isIndexValid(StringBuilder text, int index)
        {
            if (index < 0 || index >= text.Length)
            {
                return false;
            }
            return true;
        }
    }
}
