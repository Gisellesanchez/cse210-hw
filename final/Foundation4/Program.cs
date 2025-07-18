using System;
using Foundation4;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        {
            activities.Add(new Swimming(new DateTime(2023, 10, 1), 30, 20, 0.05)); // 20 laps of 0.05 miles each
            activities.Add(new Bicycles(new DateTime(2023, 10, 1), 45, 12.5)); // 12.5 miles in 45 minutes
            activities.Add(new Running(new DateTime(2023, 10, 1), 60, 5)); // 5 miles in 60 minutes
        }
        ;
        Console.WriteLine("");
        Console.WriteLine("Activities Summary:");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

    

