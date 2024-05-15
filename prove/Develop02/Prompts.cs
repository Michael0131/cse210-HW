using System;
using System.Collections.Generic;

class PromptJournal
{
    private string[] PromptList = new string[]
    {
        "What did you have for breakfast?",
        "Did you do anything fun today?",
        "Did you meet anyone new today?",
        "Did you participate in class or go to work today?",
        "Did you do anything you haven't done before today?",
        // Add more prompts here
    };

    private List<string> answers = new List<string>();

    public void AnswerPrompts(int promptCount)
    {
        // Limit the prompt count to the available number of prompts
        promptCount = Math.Min(promptCount, PromptList.Length);

        // Loop to prompt the user for answers to the specified number of prompts
        for (int i = 0; i < promptCount; i++)
        {
            // Display the prompt to the user
            Console.WriteLine($"Prompt {i + 1}: {PromptList[i]}");
            
            // Prompt the user for an answer and add it to the list of answers
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();
            
            answers.Add(answer);
        }
    }

    public void DisplayJournal()
    {
        // Display journal entries
        Console.WriteLine("\nJournal Entries:");
        for (int i = 0; i < answers.Count; i++)
        {
            // Print each prompt along with its corresponding answer
            Console.WriteLine($"Prompt {i + 1}: {PromptList[i]}");
            Console.WriteLine($"Answer: {answers[i]}\n");
        }
    }
}