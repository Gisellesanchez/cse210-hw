using System;
using System.Collections.Generic;

namespace Goals
{
    abstract class Goal
    {
        
        protected string name;
        protected string description;
        protected string goalType;

        protected int points;

        public Goal(string name, string description, int points)
        {
            this.name = name;
            this.description = description;
            this.points = points;
        }

        public abstract int RecordEvent();
        public abstract bool IsComplete();

        public string GetStatus()
        {
            return $"{name}: {description} (Type: {goalType}, Points: {points})";
        }   

        public abstract string RepresentationOfGoal();

        public void Complete()
        {
            Console.WriteLine($"Goal '{name}' completed!");
        }

    }
}
