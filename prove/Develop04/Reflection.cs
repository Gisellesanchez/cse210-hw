using System;
using System.Collections.Generic;

namespace MindfulProve
{
    class Reflection : Activity
    {
        public Reflection()
        {
            _name = "Reflection Activity";
            _description = "This activity will allow you to reflect on your thoughts and feelings, to help you gain insight and clarity.";
        }

        protected override void PerformActivity()
        {
            // Implementation of the reflection activity goes here
            Console.WriteLine("Performing reflection activity...");
            // Simulate some reflection time
            PauseWithSpinner(5);
        }
        public void ReflectOnThoughts()
        {
            Console.WriteLine("Take a moment to reflect on your thoughts and feelings.");
            Console.WriteLine("What are you grateful for today?");
            string response = Console.ReadLine();
            Console.WriteLine($"You reflected on: {response}");
        }

    }
}