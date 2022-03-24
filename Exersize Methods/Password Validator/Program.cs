using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool[] tester = new bool[1];
            CheckIfPasswordLengthIsValid(password, tester);
            CheckIfDigitsAreValid(password, tester);
            CheckIfDigitIsNum(password, tester);
            if (tester[0])
            {
                Console.WriteLine("Password is valid");
            }
        }
        static void CheckIfPasswordLengthIsValid(string password, bool[] tester)
        {
            if (password.Length>=6 && password.Length <= 10)
            {
                tester[0] = true;
                return;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }
        static void CheckIfDigitsAreValid(string password, bool[] tester)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (regexItem.IsMatch(password))
            {
                return;
            }else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                tester[0] = false;
            }
        }
        static void CheckIfDigitIsNum(string password, bool[] tester)
        {
            int sum = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    sum++;
                }
            }
            if (sum < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                tester[0] = false;
            }
        }
    }
}
