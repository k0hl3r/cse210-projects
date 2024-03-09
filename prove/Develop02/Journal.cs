using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}, {entry.Prompt}, {entry.Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split(',');
                    DateTime date = DateTime.Parse(entryData[0]);
                    string prompt = entryData[1];
                    string response = entryData[2];

                    Entry entry = new Entry(date, prompt, response);
                    entries.Add(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}