using System;

namespace Foundation3
{
    class OutdoorGathering : Event
    {
        private string _weatherForecast;
        private string _activity;

        public OutdoorGathering(string title, string description, DateTime date, Address address, string time, string weatherForecast, string activity)
            : base(title, description, date, address, time)
        {
            _weatherForecast = weatherForecast;
            _activity = activity;
        }

        public override string GetCompleteDescription()
        {
            return $"{GetBasicDescription()}\nWeather Forecast: {_weatherForecast}\nActivity: {_activity}";
        }

        public override string GetEventType()
        {
            return "Outdoor Gathering";
        }

        public override string ToString()
        {
            return $"{base.ToString()} with a weather forecast of {_weatherForecast} and activity: {_activity}";
        }
    }
}


