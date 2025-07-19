using System;
using System.Collections.Generic;

namespace Goals
{
     class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }



        public override int RecordEvent() => points;
        public override bool IsComplete() => false;
        public override string RepresentationOfGoal()
        {
            return $"{name} - {description} (Points: {points}) [Eternal Goal]";
        }

        public  string GetEternalStatus() => "Eternal goals are always active.";
    
        
    }
}