using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Running : Activity
    {
        private double _distance;

        public Running(DateTime date, int lengthMins, double distance) 
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
            return (_distance / LengthMins) * 60; 
        }

        public override double GetPace()
        {
            return LengthMins / _distance;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {_distance} miles";
        }
    }
}