using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_For_Speed_III
{
    class Car
    {
        public string CarModel { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = PutCars(n);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];

                if (commandType == "Drive")
                {
                    string car = command[1];
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    Car currCar = cars.FirstOrDefault(x => x.CarModel == car);
                    if (currCar != null)
                    {
                        if (currCar.Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                            continue;
                        }
                        currCar.Fuel -= fuel;
                        currCar.Mileage += distance;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (currCar.Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(currCar);
                            continue;
                        }
                    }
                }
                else if (commandType == "Refuel")
                {
                    string car = command[1];
                    int fuel = int.Parse(command[2]);

                    Car currCar = cars.FirstOrDefault(x => x.CarModel == car);

                    int lastFuel = currCar.Fuel;

                    if (currCar != null)
                    {
                        currCar.Fuel += fuel;
                        if (currCar.Fuel > 75)
                        {
                            currCar.Fuel = 75;
                            Console.WriteLine($"{car} refueled with {75 - lastFuel} liters");
                            continue;
                        }
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (commandType == "Revert")
                {
                    string car = command[1];
                    int kilometers = int.Parse(command[2]);

                    Car currCar = cars.FirstOrDefault(x => x.CarModel == car);
                    if (currCar != null)
                    {
                        currCar.Mileage -= kilometers;
                        if (currCar.Mileage < 10000)
                        {
                            currCar.Mileage = 10000;
                            continue;
                        }
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }
            PrintCars(cars);
        }

        private static void PrintCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.CarModel} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        static List<Car> PutCars(int n)
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carProp = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                string carName = carProp[0];
                int mileage = int.Parse(carProp[1]);
                int fuel = int.Parse(carProp[2]);

                cars.Add(new Car() { CarModel = carName, Fuel = fuel, Mileage = mileage });
            }
            return cars;
        }
    }
}
