using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxex
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(' ');
                int serialNumber = int.Parse(commands[0]);
                string itemName = commands[1];
                int itemQuantity = int.Parse(commands[2]);
                double itemPrice = double.Parse(commands[3]);

                Item newItem = new Item() { Name = itemName, Price = itemPrice };
                items.Add(newItem);

                Box newBox = new Box() { SerialNumber = serialNumber, Item = newItem, ItemQuantity = itemQuantity, PriceForBox = (newItem.Price * itemQuantity) };
                boxes.Add(newBox);
            }
            boxes = boxes.OrderBy(x => -x.PriceForBox).ToList();
            for (int i = 0; i < boxes.Count; i++)
            {
                Box currentBox = boxes[i];

                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForBox:F2}");
            }
        }
    }
}
