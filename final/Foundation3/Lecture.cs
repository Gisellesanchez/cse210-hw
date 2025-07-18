using System;

namespace Foundation3
{
    class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime date, Address address, string time, string speaker, int capacity)
            : base(title, description, date, address, time)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GetCompleteDescription()
        {
            return $"{GetBasicDescription()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
        }

        public override string GetEventType()
        {
            return "Lecture";
        }

        public override string ToString()
        {
            return $"{base.ToString()} by {_speaker} with a capacity of {_capacity}";
        }
    }
}