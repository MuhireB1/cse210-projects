using System.Collections.Generic;
using System.IO;
using System;
using System.Text.Json;

namespace JournalApp;

public class Journal
{
    // This class responsibility is to add entries to the list, display, save or load from a saved list of Entries//
    public List<Entry> _entries = new List<Entry>();

    // member methods//
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        if (_entries.Count == 0)
        {
            Console.WriteLine("There is nothing entered");
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There is nothing to save");
            return;
        }

        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine($"Saved {_entries.Count} entries to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Cannot load: file not found: {filename}");
            return;
        }

        string json = File.ReadAllText(filename);
        List<Entry> entries = JsonSerializer.Deserialize<List<Entry>>(json);

        if (entries == null)
        {
            Console.WriteLine($"No entries found in {filename}");
            return;
        }

        _entries = entries;
        Console.WriteLine($"Loaded {_entries.Count} entries from {filename}");
    }
}