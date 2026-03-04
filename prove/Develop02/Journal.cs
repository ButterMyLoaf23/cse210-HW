using System;
using System.IO.Enumeration;
using System.Xml.Linq;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add($"{entry._date} | {entry._category} | {entry._prompt} | {entry._response}");    
        }
        //
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Your Journal Entry Was Saved");
    }
}