using System;
using System.Collections.Generic;

namespace MindfulProve
{
    class Listing : Activity
    {
        public Listing()
        {
            _name = "Listing Activity";
            _description = "This activity will allow you to list things that you are grateful for, to help you focus on the positive aspects of your life.";
        }

        protected override void PerformActivity()
        {
            Console.WriteLine("Welcome to the Listing Activity!");
            Console.WriteLine("Please take a moment to list things you are grateful for.");
            List<string> items = new List<string>();
            string input;

            do
            {
                Console.Write("Enter an item (or type 'done' to finish): ");
                input = Console.ReadLine();
                if (input.ToLower() != "done" && !string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            } while (input.ToLower() != "done");

            Console.WriteLine("\nYou listed the following items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
    
}