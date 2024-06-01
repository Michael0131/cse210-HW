using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture
        Scripture scripture = new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ who strengthens me."
        );
        Console.WriteLine("\nPress Enter to hide a few random words, or type 'quit' to end:");
        string userInputToHideWords = Console.ReadLine();
        scripture.HideRandomWords(1); // Hide one words


        // bool verseCorrect = false;

        // Main loop to run the program
        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nCongratulations! You have hidden all the words. You can now try to input the entire verse:");
                string finalGuess = Console.ReadLine();
                if (scripture.CheckFullVerse(finalGuess))
                {
                    Console.Clear();
                    Console.WriteLine("\nCongratulations! You correctly entered the entire verse.");
                    Thread.Sleep(5000); // Pause for 5 seconds
                    break;
                }
                else
                {
                    Console.WriteLine("\nIncorrect guess. Try again.");
                    Thread.Sleep(2000); // Pause for 2 seconds
                    continue;
                }
            }
            if (userInputToHideWords.ToLower() == "quit")
            {
                break;
            }
            while (true)
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nGuess the hidden words:");
                string guess = Console.ReadLine();

                if (scripture.CheckGuess(guess))
                {
                    Console.WriteLine("Correct! Hiding more words.");
                    scripture.HideRandomWords(1); // Hide one more word
                    Thread.Sleep(2000);

                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again.");
                    Thread.Sleep(2000); // Pause for 2 seconds
                }
            }
        }
    }
}
