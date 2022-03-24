using System;

namespace DomashnoBeibi
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = int.Parse(Console.ReadLine());

            //if (age < 3)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (age < 14)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (age < 20)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (age < 66)
            //{
            //    Console.WriteLine("adult");
            //}
            //else
            //{
            //    Console.WriteLine("elder");
            //}

            ///Devidable num
            //int num = int.Parse(Console.ReadLine());
            //int num1 = 0;

            //if (num % 2 == 0)
            //{
            //    num1 = 2;
            //}
            //if (num % 3 == 0)
            //{
            //    num1 = 3;
            //}
            //if (num % 6 == 0)
            //{
            //    num1 = 6;
            //}
            //if (num % 7 == 0)
            //{
            //    num1 = 7;
            //}
            //if (num % 10 == 0)
            //{
            //    num1 = 10;
            //}
            //if (num % 2 != 0 && num % 3 != 0 && num % 6 != 0 && num % 7 != 0 && num % 10 != 0)
            //{
            //    Console.WriteLine("Not divisible");
            //    return;
            //}
            //Console.WriteLine($"The number is divisible by {num1}");

            ///Vacatoin
            //int numPeaple = int.Parse(Console.ReadLine());
            //string type = Console.ReadLine();
            //string dayOfTheWeek = Console.ReadLine();
            //double price = 0;

            //if (type == "Students")
            //{
            //    if (dayOfTheWeek == "Friday")
            //    {
            //        price = 8.45 * numPeaple;
            //    }
            //    else if (dayOfTheWeek == "Saturday")
            //    {
            //        price = 9.80 * numPeaple;
            //    }
            //    else if (dayOfTheWeek == "Sunday")
            //    {
            //        price = 10.46 * numPeaple;
            //    }
            //    if (numPeaple >= 30)
            //    {
            //        price = price - (price * 0.15);
            //    }
            //}
            //else if (type == "Business")
            //{
            //    if (numPeaple >= 100)
            //    {
            //        numPeaple -= 10;
            //    }
            //    if (dayOfTheWeek == "Friday")
            //    {
            //        price = 10.90 * numPeaple;
            //    }
            //    else if (dayOfTheWeek == "Saturday")
            //    {
            //        price = 15.60 * numPeaple;
            //    }
            //    else if (dayOfTheWeek == "Sunday")
            //    {
            //        price = 16 * numPeaple;
            //    }
            //}
            //else if (type == "Regular")
            //{
            //    if (dayOfTheWeek == "Friday")
            //    {
            //        price = 15 * numPeaple;
            //    }
            //    else if (dayOfTheWeek == "Saturday")
            //    {
            //        price = 20 * numPeaple;
            //    }
            //    else if (dayOfTheWeek == "Sunday")
            //    {
            //        price = 22.50 * numPeaple;
            //    }
            //    if (numPeaple >= 10 && numPeaple <= 20)
            //    {
            //        price = price - (price * 0.05);
            //    }
            //}
            //Console.WriteLine($"Total price: {price:F2}");

            ///Print And Sum
            //int nStart = int.Parse(Console.ReadLine());
            //int nFinish = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = nStart; i <= nFinish; i++)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Sum: {sum}");

            ///Login
            //string username = Console.ReadLine();
            //string password = "";
            //int counter = 0;

            //for (int i = (username.Length - 1); i >= 0; i--)
            //{
            //    password+=username[i];
            //}
            //string input = Console.ReadLine();
            //while (input != password)
            //{
            //    counter++;
            //    if (counter >= 4)
            //    {
            //        Console.WriteLine($"User {username} blocked!");
            //        return;
            //    }
            //    Console.WriteLine("Incorrect password. Try again.");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"User {username} logged in.");


            ///Strong Number
            //int num = int.Parse(Console.ReadLine());
            //string numString = num.ToString();
            //double sum1 = 0;
            //for (int y = 0; y < numString.Length; y++)
            //{
            //    double sum2 = 1;
            //    string currentNUm = numString[y].ToString();
            //    int currentNum = Convert.ToInt32(currentNUm);
            //    for (int i = 1; i <= currentNum; i++)
            //    {
            //        sum2 = sum2 * i;
            //    }
            //    sum1 += sum2;
            //}
            //if (sum1 == num)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}


            ///Vending Machine
            //string input = Console.ReadLine();
            //double sum = 0;
            //int counter = 0;
            //while (input != "Start")
            //{
            //    double money = double.Parse(input);
            //    if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2)
            //    {
            //        Console.WriteLine($"Cannot accept {money}");
            //        input = Console.ReadLine();
            //        continue;
            //    }
            //    sum += money;
            //    counter++;
            //    input = Console.ReadLine();
            //}
            //if (input == "Start" && counter == 0)
            //{
            //    Console.WriteLine($"Change: {sum:F2}");
            //    return;
            //}
            //while (input != "End")
            //{
            //    if (input == "Start")
            //    {
            //        input = Console.ReadLine();
            //        continue;
            //    }
            //    if (input == "Nuts")
            //    {
            //        if (sum >= 2)
            //        {
            //            sum -= 2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //            input = Console.ReadLine();
            //            continue;
            //        }
            //    }
            //    else if (input == "Water")
            //    {
            //        if (sum >= 0.7)
            //        {
            //            sum -= 0.7;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //            input = Console.ReadLine();
            //            continue;
            //        }
            //    }
            //    else if (input == "Crisps")
            //    {
            //        if (sum >= 1.5)
            //        {
            //            sum -= 1.5;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //            input = Console.ReadLine();
            //            continue;
            //        }
            //    }
            //    else if (input == "Soda")
            //    {
            //        if (sum >= 0.8)
            //        {
            //            sum -= 0.8;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //            input = Console.ReadLine();
            //            continue;
            //        }
            //    }
            //    else if (input == "Coke")
            //    {
            //        if (sum >= 1)
            //        {
            //        sum -= 1;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //            input = Console.ReadLine();
            //            continue;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid product");
            //        input = Console.ReadLine();
            //        continue;
            //    }
            //    Console.WriteLine($"Purchased {input.ToLower()}");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"Change: {sum:F2}");

            ///Trianglke Pyramid
            //int n = int.Parse(Console.ReadLine());

            //for (int collums = 1; collums <= n; collums++)
            //{
            //    for (int i = 0; i < collums; i++)
            //    {
            //        Console.Write(collums + " ");
            //    }
            //    Console.WriteLine();
            //}

            ///Jedai School Suplayis
            //double budget = double.Parse(Console.ReadLine());
            //int numOfStudents = int.Parse(Console.ReadLine());
            //double priceOfLIghtSaber = double.Parse(Console.ReadLine()) * (numOfStudents + Math.Ceiling(numOfStudents * 0.10));
            //double priceOfRobes = double.Parse(Console.ReadLine()) * numOfStudents;
            //        numOfStudents -= numOfStudents / 6;
            //double priceOfBelts = double.Parse(Console.ReadLine()) * numOfStudents;
            //double sum = priceOfLIghtSaber + priceOfRobes + priceOfBelts;
            //if (budget >= sum)
            //{
            //    Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            //}
            //else
            //{
            //    Console.WriteLine($" John will need {(sum - budget):F2}lv more.");
            //}

            ///Rage Is Expensive
            //int lostGames = int.Parse(Console.ReadLine());
            //double priceHeadset = double.Parse(Console.ReadLine());
            //double priceMouse = double.Parse(Console.ReadLine());
            //double priceKeyboard = double.Parse(Console.ReadLine());
            //double priceMonitor = double.Parse(Console.ReadLine());
            //int counter1 = 0;
            //int counter2 = 0;
            //int counter3 = 0;
            //int counter4 = 0;


            //for (int i = 1; i <= lostGames; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        counter1++;
            //    }
            //    if (i % 3 == 0)
            //    {
            //        counter2++;
            //    }
            //    if (i % 3 == 0 && i % 2 == 0)
            //    {
            //        counter3++;
            //    }
            //}
            //counter4 = counter3 / 2;
            //priceHeadset = priceHeadset * counter1;
            //priceMouse = priceMouse * counter2;
            //priceKeyboard = priceKeyboard * counter3;
            //priceMonitor = priceMonitor * counter4;
            //double sum = priceMonitor + priceKeyboard + priceMouse + priceHeadset;
            //Console.WriteLine($"Rage expenses: {sum:F2} lv.");

            ///Orders
            //int orders = int.Parse(Console.ReadLine());
            //double sum2 = 0;
            //for (int i = 0; i < orders; i++)
            //{
            //    double pricePerCapsule = double.Parse(Console.ReadLine());
            //    int days = int.Parse(Console.ReadLine());
            //    int capsulesCount = int.Parse(Console.ReadLine());
            //    double sum1 = ((days * capsulesCount) * pricePerCapsule);
            //    sum2 += sum1;
            //    Console.WriteLine($"The price for the coffee is: ${sum1:f2}");
            //}
            //Console.WriteLine($"Total: ${sum2:f2}");

           ///Sort
           // int num1 = int.Parse(Console.ReadLine());
           // int num2 = int.Parse(Console.ReadLine());
           // int num3 = int.Parse(Console.ReadLine());

           //int[] array = {num1, num2,num3};
           //Array.Sort(array);
           // Array.Reverse(array);
           // for (int i = 0; i < 3; i++)
           // {
           //     Console.WriteLine(array[i]);
           // }

            ///Spell The Last Digit
            //int num = int.Parse(Console.ReadLine());
            //string numString = num.ToString();

            //string lastDigit = numString[numString.Length - 1].ToString();
            //int last = int.Parse(lastDigit);
            //switch (last)
            //{
            //    case 0: Console.WriteLine("zero");
            //        break;
            //    case 1: Console.WriteLine("one");
            //        break;
            //    case 2: Console.WriteLine("two");
            //        break;
            //    case 3: Console.WriteLine("three");
            //        break;
            //    case 4: Console.WriteLine("four");
            //        break;
            //    case 5: Console.WriteLine("five");
            //        break;
            //    case 6: Console.WriteLine("six");
            //        break;
            //    case 7: Console.WriteLine("seven");
            //        break;
            //    case 8: Console.WriteLine("eight");
            //        break;
            //    case 9: Console.WriteLine("nine");
            //        break;
            //    default:
            //        break;
            //}

            ///Game Store
            //double budget = double.Parse(Console.ReadLine());
            //string input = "";
            //double counter = 0;

            //while (input != "Game Time")
            //{
            //    input = Console.ReadLine();
            //    if (input == "Game Time")
            //    {
            //        continue;
            //    }
            //    if (input == "OutFall 4" && budget >= 39.99)
            //    {
            //        budget -= 39.99;
            //        counter += 39.99;
            //        Console.WriteLine($"Bought {input}");
            //    }
            //    else if (input == "CS: OG" && budget >= 15.99)
            //    {
            //        budget -= 15.99;
            //        counter += 15.99;
            //        Console.WriteLine($"Bought {input}");

            //    }
            //    else if (input == "Zplinter Zell" && budget >= 19.99)
            //    {
            //        budget -= 19.99;
            //        counter += 19.99;
            //        Console.WriteLine($"Bought {input}");
            //    }
            //    else if (input == "Honored 2" && budget >= 59.99)
            //    {
            //        budget -= 59.99;
            //        counter += 59.99;
            //        Console.WriteLine($"Bought {input}");
            //    }
            //    else if (input == "RoverWatch" && budget >= 29.99)
            //    {
            //        budget -= 29.99;
            //        counter += 29.99;
            //        Console.WriteLine($"Bought {input}");
            //    }
            //    else if (input == "RoverWatch Origins Edition" && budget >= 39.99)
            //    {
            //        budget -= 39.99;
            //        counter += 39.99;
            //        Console.WriteLine($"Bought {input}");
            //    }
            //    else if (input != "OutFall 4" && input != "CS: OG" && input != "Zplinter Zell" && input != "Honored 2" && input != "RoverWatch" && input != "RoverWatch Origins Edition")
            //    {
            //        Console.WriteLine("Not Found");
            //        continue;
            //    } else
            //    {
            //        Console.WriteLine("Too Expensive");
            //        continue;
            //    }
            //    if (budget <= 0)
            //    {
            //        Console.WriteLine("Out of money!");
            //        return;
            //    }
            //}
            //Console.WriteLine($"Total spent: ${counter:F2}. Remaining: ${budget:F2}");

            ///Invert Words
            //string input = Console.ReadLine();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}

            ///Message Simulator
            //int n = int.Parse(Console.ReadLine());
            //string word = "";
            //for (int i = 0; i < n; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    if (input == 2)
            //    {
            //        word += "a";
            //    }
            //    else if (input == 22)
            //    {
            //        word += "b";
            //    } else if (input == 222)
            //    {
            //        word += "c";
            //    } else if (input == 3)
            //    {
            //        word += "d";
            //    } else if (input == 33)
            //    {
            //        word += "e";
            //    } else if (input == 333)
            //    {
            //        word += "f";
            //    } else if (input == 4)
            //    {
            //        word += "g";
            //    } else if (input == 44)
            //    {
            //        word += "h";
            //    } else if (input == 444)
            //    {
            //        word += "i";
            //    } else if (input == 5)
            //    {
            //        word += "j";
            //    } else if (input == 55)
            //    {
            //        word += "k";
            //    } else if (input == 555)
            //    {
            //        word += "l";
            //    } else if (input == 6)
            //    {
            //        word += "m";
            //    } else if (input == 66)
            //    {
            //        word += "n";
            //    } else if (input == 666)
            //    {
            //        word += "o";
            //    } else if (input == 7)
            //    {
            //        word += "p";
            //    } else if (input == 77)
            //    {
            //        word += "q";
            //    } else if (input == 777)
            //    {
            //        word += "r";
            //    } else if (input == 7777)
            //    {
            //        word += "s";
            //    } else if (input == 8)
            //    {
            //        word += "t";
            //    } else if (input == 88)
            //    {
            //        word += "u";
            //    } else if (input == 888)
            //    {
            //        word += "v";
            //    } else if (input == 9)
            //    {
            //        word += "w";
            //    } else if (input == 99)
            //    {
            //        word += "x";
            //    } else if (input == 999)
            //    {
            //        word += "y";
            //    } else if (input == 9999)
            //    {
            //        word += "z";
            //    } else if (input == 0)
            //    {
            //        word += " ";
            //    }
            //}
            //Console.WriteLine(word);
        }
    }
}
