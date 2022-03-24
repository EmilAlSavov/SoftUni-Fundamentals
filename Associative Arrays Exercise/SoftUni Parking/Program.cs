using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userList = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                string commandType = command[0];
                string keyName = command[1];

                if (commandType == "register")
                {
                    string licenseNumber = command[2];
                    if (userList.ContainsKey(keyName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userList[keyName]}");
                        continue;
                    }
                    userList[keyName] = licenseNumber;
                    Console.WriteLine($"{keyName} registered {licenseNumber} successfully");
                }
                else if (commandType == "unregister")
                {
                    if (!userList.ContainsKey(keyName))
                    {
                        Console.WriteLine($"ERROR: user {keyName} not found");
                        continue;
                    }
                    userList.Remove(keyName);
                    Console.WriteLine($"{keyName} unregistered successfully");
                }
            }
            PrintDic(userList);
        }

        static void PrintDic(Dictionary<string, string> userList)
        {
            foreach (var item in userList)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
