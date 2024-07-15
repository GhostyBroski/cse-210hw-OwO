using System;
using System.Collections.Generic;

class Outdoor : Event
    {
        private string WeatherStatement { get; set; }

        public Outdoor(string eventType, string title, string description, Address address, string date, string time, string weatherStatement)
            : base(eventType, title, description, address, date, time)
        {
            WeatherStatement = weatherStatement;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEventType: {EventType}\nWeather: {WeatherStatement}";
        }

        public override string GetShortDescription()
        {
            return $"{EventType}: {Title} on {Date}";
        }
    }