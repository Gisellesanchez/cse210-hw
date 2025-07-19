using System;
using System.Collections.Generic;

namespace Goals
{
    class SimpleGoal : Goal
    {
        private bool isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            this.goalType = "Simple";
            this.isComplete = false;
        }

        public override int RecordEvent()
        {
            if (!isComplete)
            {
                isComplete = true;
                Complete();
                return points;
            }
            return 0;
        }

        public override bool IsComplete()
        {
            return isComplete;
        }

        public override string RepresentationOfGoal()
        {
            return $"{name} - {description} (Points: {points})";
        }
    }
}