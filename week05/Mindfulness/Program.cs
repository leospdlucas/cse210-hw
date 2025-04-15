/*
EXCEEDING REQUIREMENTS:

Animations with spinner and countdown.
Questions and prompts dont repeat.

*/

using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice) {
                case "1": 
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    Thread.Sleep(1000);
                    continue;
            }

            activity.StartMessage();
        }
    }
}
