using System.Collections.Generic;

class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void AppendEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}