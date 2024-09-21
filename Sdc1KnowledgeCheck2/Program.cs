using System;
using System.Collections.Generic;

namespace Sdc1KnowledgeCheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine() ?? "0");

            var recordList = new List<Child>(); // Use the existing Child class

            for (int i = 0; i < numberOfRecords; i++)
            {
                var myClass = new Child();

                Console.WriteLine("Enter the Name: ");
                myClass.Name = Console.ReadLine() ?? "No Name Provided";

                Console.WriteLine("Enter the Description: ");
                myClass.Description = Console.ReadLine() ?? "No Description Provided";

                Console.WriteLine("Enter the Price: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    myClass.Price = price;
                }
                else
                {
                    Console.WriteLine("Invalid price input. Defaulting to 0.");
                    myClass.Price = 0;
                }

                Console.WriteLine("Enter the Quantity: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    myClass.Quantity = quantity;
                }
                else
                {
                    Console.WriteLine("Invalid quantity input. Defaulting to 0.");
                    myClass.Quantity = 0;
                }

                Console.WriteLine("Is it KittenFood (true/false): ");
if (bool.TryParse(Console.ReadLine(), out bool isKittenFood))
{
    myClass.KittenFood = isKittenFood;  // Now this will work
}
else
{
    Console.WriteLine("Invalid input. Defaulting to false.");
    myClass.KittenFood = false;
}


                recordList.Add(myClass);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var record in recordList)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}
