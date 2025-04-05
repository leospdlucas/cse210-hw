using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText) {
        //_date = ""; -- Not dynamic mode. It's would need to write a long text like "April 4, 2025". Users are the "best" and "always" input data correctly
        _date = DateTime.Now.ToString("yyyy-MM-dd"); // EXCEEDS -> Adds current date automatically using DateTime.Now. 
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display() {
        Console.WriteLine($"[{_date}] {_promptText}");
        Console.WriteLine($"Response: {_entryText}\n");
    }

    public override string ToString() {
        //return _entryText; // Just returns the entry text, losing the origin date and the prompt
        return $"{_date}|{_promptText}|{_entryText}"; // EXCEEDS: Converts entry to a string format for easy saving
    }
/*
    method to reconstruct an entry from a line in the file
*/
    public static Entry FromString(string line) {
        string[] parts = line.Split('|'); // EXCEEDS: Rebuilds an entry from saved data
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
