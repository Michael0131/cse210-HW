using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private HashSet<int> _hiddenIndexes; // To store indexes of hidden words

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new Word(word)).ToList();
        _hiddenIndexes = new HashSet<int>();
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(count, _words.Count(word => !word.IsHidden));

        for (int i = 0; i < wordsToHide; i++)
        {
            var visibleWords = _words.Select((word, index) => new { word, index })
                                     .Where(w => !w.word.IsHidden && !_hiddenIndexes.Contains(w.index))
                                     .ToList();
            if (visibleWords.Count > 0)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].word.Hide();
                _hiddenIndexes.Add(visibleWords[index].index);
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public bool CheckGuess(string guess)
    {
        string[] guessedWords = guess.Split(' ');

        if (guessedWords.Length != _hiddenIndexes.Count)
        {
            return false;
        }

        int hiddenWordIndex = 0;
        foreach (var index in _hiddenIndexes)
        {
            if (!_words[index].Text.Equals(guessedWords[hiddenWordIndex], StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            hiddenWordIndex++;
        }

        return true;
    }

    public bool CheckFullVerse(string guess)
    {
        string verseWithoutPunctuation = string.Join(" ", _words.Select(w => w.Text));
        return verseWithoutPunctuation.Equals(guess, StringComparison.OrdinalIgnoreCase);
    }
}
