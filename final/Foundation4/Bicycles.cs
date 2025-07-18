using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Bicycles : Activity
    {
        private double _distance;

        public Bicycles(DateTime date, int lengthMins, double distance) 
            : base(date, lengthMins)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / LengthMins) * 60; // Speed in mph
        }

        public override double GetPace()
        {
            return LengthMins / _distance; // Pace in min/mile
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {_distance} miles";
        }
    }
}