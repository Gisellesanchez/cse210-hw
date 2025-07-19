using System;
using System.Collections.Generic;

namespace Goals
{
    class ChecklistGoal : Goal
    {
        private List<string> checklistItems;
        private int completedItems;

        public ChecklistGoal(string name, string description, int points, List<string> items) : base(name, description, points)
        {
            this.goalType = "Checklist";
            this.checklistItems = items;
            this.completedItems = 0;
        }

        public override int RecordEvent()
        {
            if (completedItems < checklistItems.Count)
            {
                completedItems++;
                if (completedItems == checklistItems.Count)
                {
                    Complete();
                    return points;
                }
                return points / checklistItems.Count; 
            }
            return 0;
        }

        public override bool IsComplete()
        {
            return completedItems == checklistItems.Count;
        }

        public override string RepresentationOfGoal()
        {
            return $"{name} - {description} (Points: {points}, Completed: {completedItems}/{checklistItems.Count})";
        }
    }
}   