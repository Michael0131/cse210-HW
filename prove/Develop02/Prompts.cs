using System;
using System.Collections.Generic;

class PromptJournal
{
    // Create an array of prompts as strings
    private string[] PromptList = new string[]
    {
        "What did you have for breakfast?",
        "Did you do anything fun today?",
        "Did you meet anyone new today?",
        "Did you participate in class or go to work today?",
        "Did you do anything you haven't done before today?",
        // Add more prompts here
    };

    // List to store the answers to prompts
    private List<string> answers = new List<string>();

    // Random object for generating random numbers
    private Random random = new Random();

    // Method to answer prompts
    public void AnswerPrompts(int promptCount)
    {
        // Loop to prompt the user for answers to the specified number of prompts
        for (int i = 0; i < promptCount; i++)
        {
            // Generate a random index within the length of PromptList
            int index = random.Next(PromptList.Length);
            
            // Display the prompt to the user
            Console.WriteLine($"Prompt {i + 1}: {PromptList[index]}");
            
            // Prompt the user for an answer and add it to the list of answers
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();
            answers.Add(answer);
        }
    }

    // Method to display journal entries
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