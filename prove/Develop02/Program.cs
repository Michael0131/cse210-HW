using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of PromptJournal
        PromptJournal journal = new PromptJournal();

        // Prompt the user for the number of prompts they want to answer
        Console.Write("Enter the number of prompts you want to answer: ");
        int promptCount = int.Parse(Console.ReadLine());

        // Answer the prompts
        journal.AnswerPrompts(promptCount);

        // Display the journal entries
        journal.DisplayJournal();
    }
}