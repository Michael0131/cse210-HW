using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<Word> _hiddenWords;

    public Scripture(Reference reference, string text)

    // I got lines 14-18 from AI, I kept having issues where the code would get stuck if the user did not enter punctuation tied to the word,
    // for example -christ, would need to be entered instead of just christ
    {
        _reference = reference;
        _words = text.Split(new[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new Word(word)).ToList();
        _hiddenWords = new List<Word>();
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
            List<Word> visibleWords = _words.Where(word => !word.IsHidden && !_hiddenWords.Contains(word)).ToList();
            if (visibleWords.Count > 0)
            {
                int index = random.Next(visibleWords.Count);
                Word wordToHide = visibleWords[index];
                wordToHide.Hide();
                _hiddenWords.Add(wordToHide);
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

        foreach (var word in _hiddenWords)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return guessedWords.All(word => _hiddenWords.Any(hiddenWord => hiddenWord.Text == word));
    }

    public bool CheckFullVerse(string guess)
    {
        string[] guessedWords = guess.Split(' ');

        if (guessedWords.Length != _words.Count)
        {
            return false;
        }

        for (int i = 0; i < _words.Count; i++)
        {
            if (guessedWords[i] != _words[i].Text)
            {
                return false;
            }
        }

        return true;
    }
}
