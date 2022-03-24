using System;
using System.Linq;
using System.Collections.Generic;

namespace Vehicle_Catalog
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class VehicleCatalog
    {
        public VehicleCatalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            VehicleCatalog catalog = new VehicleCatalog();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split("/");

                string type = commands[0];
                string brand = commands[1];
                string model = commands[2];
                int horsePowerOrWeight = int.Parse(commands[3]);
                if (type == "Car")
                {
                    Car newCar = new Car() { Brand = brand, Model = model, HorsePower = horsePowerOrWeight };
                    catalog.Cars.Add(newCar);
                } else if (type == "Truck")
                {
                    Truck newTruck = new Truck() { Brand = brand, Model = model, Weight = horsePowerOrWeight };
                    catalog.Trucks.Add(newTruck);
                }
            }
            Console.WriteLine("Cars:");
            List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
            for (int i = 0; i < orderedCars.Count; i++)
            {
                Console.WriteLine($"{orderedCars[i].Brand}: {orderedCars[i].Model} - {orderedCars[i].HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            List<Truck> orderedTruck = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
            for (int i = 0; i < orderedTruck.Count; i++)
            {
                Console.WriteLine($"{orderedTruck[i].Brand}: {orderedTruck[i].Model} - {orderedTruck[i].Weight}kg");
            }
        }
    }
}
