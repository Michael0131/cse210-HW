using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Psalm", 23, 1, 2), "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength. They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint."),
            new Scripture(new Reference("Matthew", 6, 33), "But seek first his kingdom and his righteousness, and all these things will be given to you as well."),
            new Scripture(new Reference("Jeremiah", 29, 11), "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."),
            new Scripture(new Reference("1 Corinthians", 13, 4, 5), "Love is patient, love is kind. It does not envy, it does not boast, it is not proud. It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs."),
            new Scripture(new Reference("Ephesians", 2, 8, 9), "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God—not by works, so that no one can boast."),
            new Scripture(new Reference("2 Timothy", 1, 7), "For the Spirit God gave us does not make us timid, but gives us power, love and self-discipline."),
            new Scripture(new Reference("James", 1, 2, 3), "Consider it pure joy, my brothers and sisters, whenever you face trials of many kinds, because you know that the testing of your faith produces perseverance."),
            new Scripture(new Reference("1 Peter", 5, 7), "Cast all your anxiety on him because he cares for you."),
            new Scripture(new Reference("Psalm", 46, 1), "God is our refuge and strength, an ever-present help in trouble."),
            new Scripture(new Reference("Hebrews", 11, 1), "Now faith is confidence in what we hope for and assurance about what we do not see."),
            new Scripture(new Reference("John", 14, 6), "Jesus answered, I am the way and the truth and the life. No one comes to the Father except through me."),
            new Scripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest."),
            new Scripture(new Reference("Romans", 12, 2), "Do not conform to the pattern of this world, but be transformed by the renewing of your mind. Then you will be able to test and approve what God’s will is—his good, pleasing and perfect will."),
            new Scripture(new Reference("Proverbs", 3, 6), "In all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Joshua", 1, 9), "Have I not commanded you? Be strong and courageous. Do not be afraid; do not be discouraged, for the Lord your God will be with you wherever you go.")
        };

        // Select a random scripture from the library
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        // Main loop to run the program
        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nYou have hidden all the words. You can now try to input the entire verse:");
                string finalGuess = Console.ReadLine();
                if (scripture.CheckGuess(finalGuess))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nIncorrect guess. Try again.");
                    Thread.Sleep(2000); // Pause for 2 seconds
                    continue;
                }
            }

            Console.WriteLine("\nPress Enter to hide a few random words, or type 'quit' to end:");
            string userInputToHideWords = Console.ReadLine();

            if (userInputToHideWords.ToLower() == "quit")
            {
                break;
            }

            bool correctGuess = false;
            while (!correctGuess)
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nGuess the hidden words:");
                string guess = Console.ReadLine();

                if (scripture.CheckGuess(guess))
                {
                    Console.WriteLine("Correct! Hiding more words.");
                    scripture.HideRandomWords(3); // Hide three more words
                    correctGuess = true; // Set the flag to true to exit the loop
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again.");
                }
            }

        }

    }

}
