using System;
using System.Threading.Tasks;
using System.Threading;


namespace MindfulProve
{
    class Breathing : Activity
    {
        public Breathing()
        {
            _name = "Breathing Activity";
            _description = "This activity will allow you to focus on your breathing, to help you relax and reduce stress.";

        }
        protected override void PerformActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nBreathe in...");
                Thread.Sleep(4000); // Simulate breathing in for 2 seconds
                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000); // Simulate breathing out for 2 seconds
                



                Console.WriteLine("Keep breathing...");}
        }

    } }