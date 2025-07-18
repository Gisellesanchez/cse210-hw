using System;

namespace Foundation3
{
    abstract class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private Address _address;

        private string _time;

        public Event(string title, string description, DateTime date, Address address, string time)
        {
            _title = title;
            _description = description;
            _date = date;
            _address = address;
            _time = time;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetBasicDescription()
        {
            return $"Title: {GetTitle()}\n Description: {_description}\n Date: {_date}\n Time: {_time}\nAddress: {_address.GetFullAddress()}";
        }

        public abstract string GetCompleteDescription();
        
        public virtual string GetSmallDescription()
        {
            return $"{GetTitle()} on {GetDate().ToShortDateString()} at {GetAddress()}";
        }
        public DateTime GetDate()
        {
            return _date;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public abstract string GetEventType();

        public override string ToString()
        {
            return $"{GetEventType()} - {GetTitle()} on {GetDate().ToShortDateString()} at {GetAddress()}";
        }
    }
}