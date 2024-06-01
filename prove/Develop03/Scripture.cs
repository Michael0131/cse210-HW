using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private string text;
    private List<string> hiddenWords;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        hiddenWords = new List<string>();
    }

    public void Display()
    {
        string displayedText = text;

        // Replace hidden words with underscores
        foreach (string word in hiddenWords)
        {
            displayedText = displayedText.Replace(word, new string('_', word.Length));
        }

        Console.WriteLine($"{reference}:");
        Console.WriteLine(displayedText);
    }

    public void HideRandomWords(int count)
    {
        List<string> wordsToHide = GetRandomWordsToHide(count);
        hiddenWords.AddRange(wordsToHide);
    }

    private List<string> GetRandomWordsToHide(int count)
    {
        // Split the text into words
        string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        // Filter out words that are already hidden
        words = words.Where(word => !hiddenWords.Contains(word)).ToArray();

        // Shuffle the words randomly
        Random random = new Random();
        words = words.OrderBy(word => random.Next()).ToArray();

        // Take 'count' number of words from the shuffled list
        List<string> wordsToHide = words.Take(count).ToList();
        return wordsToHide;
    }

    public bool AllWordsHidden()
    {
        // Split the text into words
        string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        // Check if all words are in the hidden list
        return words.All(word => hiddenWords.Contains(word));
    }

    public bool CheckGuess(string guess)
    {
        // Split the guess into words
        string[] guessedWords = guess.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        // Check if all guessed words are in the hidden list
        return guessedWords.All(word => hiddenWords.Contains(word));
    }
}
