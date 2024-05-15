using System;

class Entry
{
    public string _dateTime { get; set; }
    public string _givenPrompt { get; set; }
    public string _response { get; set; }

    // Constructor
    public Entry(string dateTime, string givenPrompt, string response)
    {
        _dateTime = dateTime;
        _givenPrompt = givenPrompt;
        _response = response;
    }

    // Method to display journal entry
    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime}\nPrompt: {_givenPrompt}\nResponse: {_response}");
    }

    public override string ToString()
    {
        return $"{_dateTime}|{_givenPrompt}|{_response}";
    }

    // Static method to create an entry from a formatted string
    public static Entry FromString(string entryString)
    {
        var parts = entryString.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}