using System;
using System.Collections.Generic;

class Event
    {
        public string EventType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public Event(string eventType, string title, string description, Address address, string date, string time)
        {
            EventType = eventType;
            Title = title;
            Description = description;
            Address = address;
            Date = date;
            Time = time;
        }

        public string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address.GetAddressLabel()}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"{EventType}: {Title} on {Date}";
        }
    }