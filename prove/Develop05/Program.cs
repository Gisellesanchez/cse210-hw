using System;
using Goals;


class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score =0;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Tracker!");
        Console.WriteLine("You can create goals, record events, and track your score.");
        {
            while (true)
            {
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Show Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ChecklistGoal(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": ShowScore(); break;
                    case "6": Exit(); return;
                    case "7": ShowGoalStatus(); break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void CreateGoal()
        {
            Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
            string type = Console.ReadLine();
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points for the goal: ");
            int points = int.Parse(Console.ReadLine());

            if (type.Equals("Simple", StringComparison.OrdinalIgnoreCase))
            {
                goals.Add(new SimpleGoal(name, description, points));
            }
            else if (type.Equals("Eternal", StringComparison.OrdinalIgnoreCase))
            {
                goals.Add(new EternalGoal(name, description, points));
            }
            else if (type.Equals("Checklist", StringComparison.OrdinalIgnoreCase))
            {
                List<string> items = new List<string>();
                Console.Write("Enter checklist items (comma separated): ");
                string[] itemArray = Console.ReadLine().Split(',');
                foreach (var item in itemArray)
                {
                    items.Add(item.Trim());
                }
                goals.Add(new ChecklistGoal(name, description, points, items));
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }
        }
    
     static void ChecklistGoal()
        {
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
            }
        }
            static void SaveGoals()
            {
                foreach (var goal in goals)
                {
                    Console.WriteLine(goal.RepresentationOfGoal());
                }
            }
            static void LoadGoals()
            {

                Console.WriteLine("Filename to load:");
                var filename = Console.ReadLine();
                if (System.IO.File.Exists(filename))
                {
                    var lines = System.IO.File.ReadAllLines(filename);
                    foreach (var line in lines)
                    {
                        var parts = line.Split('|');
                        if (parts.Length < 4) continue;

                        string type = parts[0].Trim();
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        int points = int.Parse(parts[3].Trim());

                        if (type.Equals("Simple", StringComparison.OrdinalIgnoreCase))
                        {
                            goals.Add(new SimpleGoal(name, description, points));
                        }
                        else if (type.Equals("Eternal", StringComparison.OrdinalIgnoreCase))
                        {
                            goals.Add(new EternalGoal(name, description, points));
                        }
                        else if (type.Equals("Checklist", StringComparison.OrdinalIgnoreCase))
                        {
                            List<string> items = new List<string>(parts[4].Split(','));
                            goals.Add(new ChecklistGoal(name, description, points, items));
                        }

                    }
                    static void RecordGoalEvent()
                    {
                        ChecklistGoal();
                        Console.Write("Enter the number of the goal to record an event: ");
                        int goalNumber;
                        if (int.TryParse(Console.ReadLine(), out goalNumber) && goalNumber > 0 && goalNumber <= goals.Count)
                        {
                            int pointsEarned = goals[goalNumber - 1].RecordEvent();
                            if (pointsEarned > 0)
                            {
                                score += pointsEarned;
                                Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
                            }
                            else
                            {
                                Console.WriteLine("Goal already completed or no points earned.");
                            }


                        }

                    }

                }
            }
        }
        static void ShowScore()
        {
            Console.WriteLine($"Your current score is: {score}");
        }

        static void Exit()
        {
            Console.WriteLine("Exiting the program. Goodbye!");
        }

        static void ShowGoalStatus()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.RepresentationOfGoal());
            }
        }
    }
