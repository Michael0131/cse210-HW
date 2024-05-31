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

        // Main loop to run the program
        while (true)
        {
            Console.Clear();
            scripture.Display();

            // Check if all words are hidden, then end the program
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nCongratulations! You have hidden all the words. You can now try to input the entire verse.");
                Thread.Sleep(5000); // Pause for 5 seconds
                break;
            }

            Console.WriteLine("\nPress Enter to hide a few random words, or type 'quit' to end:");
            string userInputToHideWords = Console.ReadLine();

            // Exit the program if user types 'quit'
            if (userInputToHideWords.ToLower() == "quit")
            {
                break;
            }

            // Hide random words and prompt user to guess them
            scripture.HideRandomWords(3); // Hide three words
            while (true)
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nGuess the hidden words:");
                string guess = Console.ReadLine();

                // Check if the guess is correct
                if (scripture.CheckGuess(guess))
                {
                    Console.WriteLine("Correct! Hiding more words.");
                    scripture.HideRandomWords(3); // Hide three more words
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again.");
                }
            }
        }
    }
}
