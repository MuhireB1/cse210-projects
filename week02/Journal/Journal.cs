using System.Collections.Generic;
using System.IO;
using System;

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
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            if (_entries.Count != 0)
            {
                string dateString = DateTime.Now.ToShortDateString();
                outputFile.WriteLine($"Date: {dateString}");
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            else
            {
                Console.WriteLine("There is nothing to save");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        // Clear existing entries before loading
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
}