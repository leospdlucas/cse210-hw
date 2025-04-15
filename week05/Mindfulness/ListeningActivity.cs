using System;
using System.Collections.Generic;

public class ListingActivity : Activity {
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private HashSet<int> _usedPrompts = new(); //EXCEEDING
    private Random _random = new();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { 

    }

    private string GetRandomPrompt() {
        if (_usedPrompts.Count == _prompts.Count)
            _usedPrompts.Clear(); //EXCEEDING
            int index;

        do {
            index = _random.Next(_prompts.Count);
        } 
        
        while (_usedPrompts.Contains(index)); //EXCEEDING
        _usedPrompts.Add(index);

        return _prompts[index];
    }

    public override void Run() {
        StartMessage();
        Console.WriteLine("\n" + GetRandomPrompt());
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5); //EXCEEDING

        List<string> items = new();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end) {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndingMessage();
    }
}
