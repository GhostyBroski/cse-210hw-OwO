using System;
using System.Collections.Generic;

class Reception : Event
    {
        private string ContactRSVP { get; set; }

        public Reception(string eventType, string title, string description, Address address, string date, string time, string contactRSVP)
            : base(eventType, title, description, address, date, time)
        {
            ContactRSVP = contactRSVP;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEventType: {EventType}\nRSVP Contact: {ContactRSVP}";
        }

        public override string GetShortDescription()
        {
            return $"{EventType}: {Title} on {Date}";
        }
    }