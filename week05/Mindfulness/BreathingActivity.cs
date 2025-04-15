using System;

public class BreathingActivity : Activity {
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { 

    }
public override void Run() {
        StartMessage();
        int seconds = GetDuration();
        int interval = 4;

        while (seconds > 0) {
            Console.Write("Breathe in... ");
            ShowCountDown(interval);  //EXCEEDING
            seconds -= interval;

            if (seconds <= 0) break;

            Console.Write("Breathe out... ");
            ShowCountDown(interval); //EXCEEDING
            seconds -= interval;
        }

        EndingMessage();
    }
}
