using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Swimming : Activity
    {
        private double _laps;
        private double _lapLength; // Length of a lap in miles

        public Swimming(DateTime date, int lengthMins, double laps, double lapLength) 
            : base(date, lengthMins)
        {
            _laps = laps;
            _lapLength = lapLength;
        }

        public override double GetDistance()
        {
            return _laps * _lapLength; // Total distance in miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthMins) * 60; // Speed in mph
        }

        public override double GetPace()
        {
            return LengthMins / GetDistance(); // Pace in min/mile
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Laps: {_laps}, Lap Length: {_lapLength} miles";
        }
    }
}