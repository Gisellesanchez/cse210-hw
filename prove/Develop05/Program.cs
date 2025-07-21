using System;
using Goals;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordGoalEvent(); break;
                case "6": Console.WriteLine($"Current Score: {score}"); break;
                case "7": return;
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1=Simple 2=Eternal 3=Checklist");
        var type = Console.ReadLine();
        Console.Write("Name: "); var name = Console.ReadLine();
        Console.Write("Description: "); var description = Console.ReadLine();
        Console.Write("Points: "); var points = int.Parse(Console.ReadLine());

        if (type == "1") goals.Add(new SimpleGoal(name, description, points));
        else if (type == "2") goals.Add(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            Console.Write("Target Count: "); var target = int.Parse(Console.ReadLine());
            Console.Write("Bonus Points: "); var bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal.(name, description, points, target, bonus));
        }
        else Console.WriteLine("Invalid goal type.");
    }

    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    static void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? (number): ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals()
    {
        Console.Write("Filename to save: ");
        var filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.RepresentationOfGoal());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals()
    {
        Console.Write("Filename to load: ");
        var filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split(":");
            var type = parts[0];
            var values = parts[1].Split(',');

            if (type == "SimpleGoal")
                goals.Add(new SimpleGoal.(values[0], values[1], int.Parse(values[2]), bool.Parse(values[3])));
            else if (type == "EternalGoal")
                goals.Add(new EternalGoal(values[0], values[1], int.Parse(values[2])));
            else if (type == "ChecklistGoal")
                goals.Add(new ChecklistGoal.(values[0], values[1], int.Parse(values[2]), int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
        }
        Console.WriteLine("Goals loaded.");
    }
}
