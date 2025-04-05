using System;
using System.Collections.Generic;
using System.IO;

public class Journal {
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        Console.WriteLine("\n**** Journal Entries ****\n");
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }
/*
    public void SaveToFile(string file) {        
        StreamWriter writer = new StreamWriter(file);
        foreach (Entry entry in _entries) {
            writer.WriteLine(entry.ToString());
        }
        writer.Close(); // Must remember to close manually
    }

    This way, if an error occurs, the file may not be closed correctly
*/
    public void SaveToFile(string file) {
        using (StreamWriter writer = new StreamWriter(file)) { // EXCEEDS: 'using' for safe file handling
            foreach (Entry entry in _entries) {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file) {
        if (File.Exists(file)) {
            _entries.Clear(); // clear the entries before loading from file, avoiding duplicate
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines) {
                _entries.Add(Entry.FromString(line));
            }
            Console.WriteLine("Journal loaded successfully!");
        } else {
            Console.WriteLine("File not found.");
        }
    }
}
