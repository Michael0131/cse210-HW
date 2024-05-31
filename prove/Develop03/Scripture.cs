using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference; // Holds the scripture reference
    private List<Word> _words; // Holds the list of words in the scripture
    private List<Word> _originalHiddenWords; // Holds the list of originally hidden words
    private List<Word> _additionalHiddenWords; // Holds the list of additional hidden words

    // Constructor to initialize the scripture
    public Scripture(Reference reference, string text)

    {
        // I kept hvaing issues where the code would break when punctuation was tied to the word in my list, this is a solution i used from AI
        _reference = reference;
        _words = text.Split(new[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new Word(word)).ToList();
        _originalHiddenWords = new List<Word>();
        _additionalHiddenWords = new List<Word>();
    }

    // Display the scripture with hidden words as blanks
    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    // Hide a few random words
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(count, _words.Count(word => !word.IsHidden)); // Determine the number of words to hide

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = _words.Where(word => !word.IsHidden && !_originalHiddenWords.Contains(word)).ToList();
            if (visibleWords.Count > 0)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                _additionalHiddenWords.Add(visibleWords[index]); // Add to the list of additional hidden words
            }
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    // Check if the user's guess for hidden words is correct
    public bool CheckGuess(string guess)

    {
        // I was given the solution to split guess by a space, 
        // I was going to make it print out word 1: word 2: etc, but AI gave this better solution.
        string[] guessedWords = guess.Split(' ');

        if (guessedWords.Length != _additionalHiddenWords.Count)
        {
            return false;
        }
        foreach (var word in _originalHiddenWords)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        foreach (var word in _additionalHiddenWords)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }

    // Reset the scripture to the original state
    public void Reset()
    {
        foreach (var word in _words)
        {
            word.Reveal(); // Reveal all hidden words
        }
        _additionalHiddenWords.Clear(); // Clear the list of additional hidden words
    }
}
