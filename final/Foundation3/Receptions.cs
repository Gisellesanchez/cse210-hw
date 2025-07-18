using System;

namespace Foundation3
{
    class Receptions : Event
    {
        private string _organizer;
        private string _dressCode;

        private string _rsvpEmail;

        public Receptions(string title, string description, DateTime date, Address address, string time, string organizer, string dressCode, string rsvpEmail)
            : base(title, description, date, address, time)
        {
            _organizer = organizer;
            _dressCode = dressCode;
            _rsvpEmail = rsvpEmail;
        }

        public override string GetCompleteDescription()
        {
            return $"{GetBasicDescription()}\nOrganizer: {_organizer}\nDress Code: {_dressCode}\nRSVP Email: {_rsvpEmail}";
        }

        public override string GetEventType()
        {
            return "Receptions";
        }

        public override string ToString()
        {
            return $"{base.ToString()} organized by {_organizer} with a dress code of {_dressCode}";
        }
    }
}