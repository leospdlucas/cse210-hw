using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity {
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about it?",
        "What did you learn from this?",
        "How can you apply this in the future?"
    };

    private HashSet<int> _usedPrompts = new(); //EXCEEDING
    private HashSet<int> _usedQuestions = new(); //EXCEEDING
    private Random _random = new();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { 

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

    private string GetRandomQuestion() {
        if (_usedQuestions.Count == _questions.Count)
            _usedQuestions.Clear(); //EXCEEDING
            int index;

        do {
            index = _random.Next(_questions.Count);
        } 
        
        while (_usedQuestions.Contains(index)); //EXCEEDING
        _usedQuestions.Add(index);
        return _questions[index];
    }

    public override void Run() {
        StartMessage();
        Console.WriteLine("\n" + GetRandomPrompt());
        ShowSpinner(3); //EXCEEDING

        int elapsed = 0;
        while (elapsed < GetDuration()) {
            string q = GetRandomQuestion();
            Console.WriteLine("> " + q);
            ShowSpinner(5); //EXCEEDING
            elapsed += 5;
        }

        EndingMessage();
    }
}
