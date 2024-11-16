using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (var line in lines)
        {
            Entry entry = Entry.FromString(line);
            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}
