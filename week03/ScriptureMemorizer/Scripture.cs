using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(word => new Word(word))
                     .ToList();
    }

    public void HideRandomWords(int numberToHide) {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++) {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText() {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public bool IsCompletelyHidden() {
        return _words.All(w => w.IsHidden());
    }

// EXCEED: Memorizer Progress
    public int GetHiddenPercentage() {
        if (_words.Count == 0) return 0;

        int hiddenCount = _words.Count(w => w.IsHidden());
        return (int)((hiddenCount / (double)_words.Count) * 100);
    }

// EXCEED: Progress bar
    public string GetProgressBar(int barLength = 20) {
        int percentage = GetHiddenPercentage();
        int filledLength = (int)(barLength * percentage / 100.0);

        string bar = new string('█', filledLength) + new string('-', barLength - filledLength);
        return $"[{bar}] {percentage}% oculto";
    }
}
