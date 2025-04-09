// This program exceeds the core requirements by:
// - Displaying a progress bar showing the percentage of words hidden.
// - Helping the user visually track scripture memorization progress.
using System;

class Program {
    static void Main(string[] args) {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        while (true) {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\nProgress: {scripture.GetProgressBar()}"); // EXCEED: Progress bar
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit."); 
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (!scripture.IsCompletelyHidden()) {
                scripture.HideRandomWords(3);

            } else {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nMemorization complete! All words have been hidden.");
                break;
            }
        }
    }
}