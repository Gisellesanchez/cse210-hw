using System;
using MindfulProve;
using System.Threading.Tasks;
using System.Threading;


class Program
{
      static Dictionary<string, int> _activityCount = new Dictionary<string, int>
    {
        {"Breathing", 0},
        {"Reflection", 0},
        {"Listing", 0}
    };
    static void Main(string[] args)
    {
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindful Prove Program!");
                Console.WriteLine("Please select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new Reflection(),
                    "3" => new Listing(),
                    _ => null
                };
                if (activity == null && choice != "4")
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    Thread.Sleep(2000); // Simulate a short delay before showing the menu again
                    continue;
                }
                if (activity != null)
                {
                    _activityCount[activity.GetType().Name.Replace("Activity", "")] ++;
                    activity.Start();

                }
                else if (choice == "4")
                {
                    Console.WriteLine("\nSession Summary:");
                    foreach (var kvp in _activityCount)
                    {
                        Console.WriteLine($"{kvp.Key} Activity Count: {kvp.Value}");
                    }
                    Console.WriteLine("Thank you for participating in the Mindful Prove Program!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    Console.ReadLine();
              
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    Thread.Sleep(2000);
                }


            }
            ;
        }
    }

    }
