using System;
using System.Globalization;

namespace Condisional_Statements_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /// student info
            //string name = console.readline();
            //int age = int.parse(console.readline());
            //double grade = double.parse(console.readline());

            //console.writeline($"name: {name}, age: {age}, grade: {grade:f2}");

            ///passed
            //double grade = double.parse(console.readline());

            //if (grade >= 3.00)
            //{
            //    console.writeline("passed!");
            //}

            ///passed or failed
            //double grade = double.parse(console.readline());
            //if (grade >= 3.00)
            //{
            //    console.writeline("passed!");
            //}
            //else
            //{
            //    console.writeline("failed!");
            //}

            ///back in 30 minutes
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());

            //int total = (hours * 60 + minutes) + 30;

            //int hoursafter = total / 60;
            //int minutesafter = total % 60;

            //if (hoursafter >= 24 && minutesafter > 0)
            //{
            //    hoursafter = 0;
            //}
            //Console.WriteLine($"{hoursafter}:{minutesafter:d2}");

            ///month printer
            //int num = int.parse(console.readline());

            //switch (num)
            //{
            //    case 1:
            //        console.writeline("january");
            //        break;
            //    case 2:
            //        console.writeline("february");
            //        break;
            //    case 3:
            //        console.writeline("march");
            //        break;
            //    case 4:
            //        console.writeline("april");
            //        break;
            //    case 5:
            //        console.writeline("may");
            //        break;
            //    case 6:
            //        console.writeline("june");
            //        break;
            //    case 7:
            //        console.writeline("july");
            //        break;
            //    case 8:
            //        console.writeline("august");
            //        break;
            //    case 9:
            //        console.writeline("september");
            //        break;
            //    case 10:
            //        console.writeline("october");
            //        break;
            //    case 11:
            //        console.writeline("november");
            //        break;
            //    case 12:
            //        console.writeline("december");
            //        break;
            //    default:
            //        console.writeline("error!");
            //        break;
            //}

            ///foreign languages
            //string country = console.readline();

            //if (country == "england" || country == "usa")
            //{
            //    console.writeline("english");
            //}
            //else if (country == "spain" || country == "argentina" || country == "mexico")
            //{
            //    console.writeline("spanish");
            //}
            //else
            //{
            //    console.writeline("unknown");
            //}

            ///theatre promotions
            //string typeofday = console.readline();
            //int age = int.parse(console.readline());
            //double price = 0;

            //if (typeofday == "weekday")
            //{
            //    if (age >= 0 && age <= 18)
            //    {
            //        price = 12;
            //    }
            //    else if (age > 18 && age <= 64)
            //    {
            //        price = 18;
            //    }
            //    else if (age > 64 && age <= 122)
            //    {
            //        price = 12;
            //    }
            //    else
            //    {
            //        console.writeline("error!");
            //        return;
            //    }
            //}
            //else if (typeofday == "weekend")
            //{
            //    if (age >= 0 && age <= 18)
            //    {
            //        price = 15;
            //    }
            //    else if (age > 18 && age <= 64)
            //    {
            //        price = 20;
            //    }
            //    else if (age > 64 && age <= 122)
            //    {
            //        price = 15;
            //    }
            //    else
            //    {
            //        console.writeline("error!");
            //        return;
            //    }
            //}
            //else if (typeofday == "holiday")
            //{
            //    if (age >= 0 && age <= 18)
            //    {
            //        price = 5;
            //    }
            //    else if (age > 18 && age <= 64)
            //    {
            //        price = 12;
            //    }
            //    else if (age > 64 && age <= 122)
            //    {
            //        price = 10;
            //    } else
            //    {
            //        console.writeline("error!");
            //        return;
            //    }
            //}
            //else
            //{
            //    console.writeline("error!");
            //}
            //console.writeline(price + "$");
            ///devided by 3
            //for (int i = 3; i <= 100; i+=3)
            //{
            //    console.writeline(i);
            //}

            ///sum of odd numbers
            //int n = int.parse(console.readline());
            //int sum = 0;
            //int y = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    console.writeline(y);
            //    sum += y;
            //    y += 2;
            //}
            //console.writeline("sum: " + sum);

            ///multiply table
            //int n = int.parse(console.readline());

            //for (int i = 1; i <= 10; i++)
            //{
            //    console.writeline($"{n} x {i} = {n*i}");
            //}

            ///multiply table 2.0
            //int n = int.parse(console.readline());
            //int row = int.parse(console.readline());

            //for (int i = row; i <= 10; i++)
            //{
            //    console.writeline($"{n} x {i} = {n * i}");
            //}
            //if (row > 10)
            //{
            //    console.writeline($"{n} x {row} = {n * row}");
            //}

            ///Even Number
            //int n;
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n < 0)
            //    {
            //        n = Math.Abs(n);
            //    }
            //    if (n % 2 == 0)
            //    {
            //        Console.WriteLine("The number is: " + n);
            //        return;
            //    }
            //    Console.WriteLine("Please write an even number.");
            //} while (n % 2 != 0);


            ///Debug The Code
            //var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
            //var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //var holidaysCount = 0;
            //for (var date = startDate; date <= endDate; date = date.AddDays(1))
            //{
            //    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            //    {
            //        holidaysCount++;
            //    }
            //}
            //Console.WriteLine(holidaysCount);

        }
    }
}
