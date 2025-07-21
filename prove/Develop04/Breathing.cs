using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;



namespace MindfulProve
{
    class BreathingActivity : Activity  
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will allow you to focus on your breathing, to help you relax and reduce stress.";

        }
        protected override void PerformActivity()
        {
            int elapsed = 0;
            Console.WriteLine("Welcome to the Breathing Activity!");
            Console.WriteLine("This activity will help you focus on your breathing to relax and reduce stress.");

            while (elapsed < _duration)
            {
                Console.Clear();
                Console.WriteLine("Get ready to start the breathing exercise.");
                Console.WriteLine("Press any key to begin...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Breathe in...");
                Thread.Sleep(4000); // Simulate breathing in for 2 seconds
                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000); // Simulate breathing out for 2 seconds

                elapsed += 4; // Increment elapsed time by 8 seconds
                {
                    Console.WriteLine("\nBreathe in...");
                    Thread.Sleep(4000); // Simulate breathing in for 2 seconds
                    Console.WriteLine("Breathe out...");
                    Thread.Sleep(4000); // Simulate breathing out for 2 seconds




                    Console.WriteLine("Keep breathing...");
                }
            }

        }
    }
}