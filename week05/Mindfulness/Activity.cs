using System;
using System.Threading;

public abstract class Activity {
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public void StartMessage() {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to start...");
        ShowSpinner(3); //EXCEEDING
    }

    public void EndingMessage() {
        Console.WriteLine("\nCongrats!");
        ShowSpinner(2); //EXCEEDING
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.\n");
        ShowSpinner(3); //EXCEEDING
    }

    protected void ShowCountDown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    //EXCEEDING
    protected void ShowSpinner(int seconds) {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end) {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    public int GetDuration() => _duration;

    public abstract void Run();

}
