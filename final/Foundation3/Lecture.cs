using System;
using System.Collections.Generic;

class Lecture : Event
    {
        public string Speaker { get; set; }
        public uint Capacity { get; set; }

        public Lecture(string eventType, string title, string description, Address address, string date, string time, string speaker, uint capacity)
            : base(eventType, title, description, address, date, time)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}\nEvent Type: {EventType}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }

        public override string GetShortDescription()
        {
            return $"{EventType}: {Title} on {Date}";
        }
    }