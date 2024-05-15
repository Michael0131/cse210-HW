using System;

class Program
{
    static void Main(string[] args)
    {
        PromptJournal journal = new PromptJournal();

        Console.Write("Enter the number of prompts to answer: ");
        int promptCount = int.Parse(Console.ReadLine());

        journal.AnswerPrompts(promptCount);
        journal.DisplayJournal();
    }
}