using System;
using System.Collections.Generic;

class Event
    {
        protected string EventType { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected Address Address { get; set; }
        protected string Date { get; set; }
        protected string Time { get; set; }

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