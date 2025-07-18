using System;
using System.Collections.Generic;


namespace Foundation4
{
    abstract class Activity
    {
        private DateTime _date;
        private int _lengthMins;

        public Activity(DateTime date, int lengthMins)
        {
            _date = date;
            _lengthMins = lengthMins;
        }

        public DateTime Date => _date;
        public int LengthMins => _lengthMins;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthMins} mins) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        }
    }
    }
       
