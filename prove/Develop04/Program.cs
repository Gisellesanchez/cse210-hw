using System;
using MindfulProve;
using System.Threading.Tasks;
using System.Threading;


class Program
{
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
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Breathing Breathing = new Breathing();
                        break;

                    case "2":
                        Reflection reflectionActivity = new Reflection();
                        break;

                    case "3":
                        Listing listingActivity = new Listing();
                        break;
                        
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;

                } 
            }
        }
      
    }
}