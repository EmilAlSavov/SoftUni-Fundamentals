using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalog
{
    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        
        public double HorsePower { get; set; }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> cars  = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();
            
            AddVehicles(cars, trucks, vehicles);

            PrintVehicles(vehicles);

            PrintAverageHorsePower(cars, trucks);

        }
        static void AddVehicles(List<Vehicle> cars, List<Vehicle> trucks, List<Vehicle> vehicles)
        {
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = command[0];
                string model = command[1];
                string color = command[2];
                double horsePower = double.Parse(command[3]);

                if (type == "truck")
                {
                    Vehicle truck = new Vehicle() { Type = type, Model = model, Color = color, HorsePower = horsePower };
                    trucks.Add(truck);
                    vehicles.Add(truck);
                }
                else if (type == "car")
                {
                    Vehicle car = new Vehicle() { Type = type, Color = color, HorsePower = horsePower, Model = model };
                    cars.Add(car);
                    vehicles.Add(car);
                }
            }
        }

        static void PrintVehicles(List<Vehicle> vehicles)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string modelToPick = input;
                Vehicle currentVehicle = vehicles.FirstOrDefault(v => v.Model == modelToPick);

                if (currentVehicle != null)
                {
                    if (currentVehicle.Type == "car")
                    {
                        Console.WriteLine($"Type: Car");
                    }
                    else
                    {
                        Console.WriteLine("Type: Truck");
                    }
                    Console.WriteLine($"Model: {currentVehicle.Model}");
                    Console.WriteLine($"Color: {currentVehicle.Color}");
                    Console.WriteLine($"Horsepower: {currentVehicle.HorsePower}");
                }
            }
        }

        static void PrintAverageHorsePower(List<Vehicle> cars, List<Vehicle> trucks)
        {
            
            
            double carHPSum = 0;
            double truckHPSum = 0;

            double carHP = 0;
            double truckHP = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                carHPSum += cars[i].HorsePower;
            }

            for (int i = 0;i < trucks.Count; i++)
            {
                truckHPSum += trucks[i].HorsePower;
            }
            carHP = (carHPSum / cars.Count);
            truckHP = (truckHPSum / trucks.Count);

            if (cars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {carHP:F2}.");
            }

            if (trucks.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckHP:F2}.");
            }
        }
    }
}
