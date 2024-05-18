using System;
using System.Collections.Generic;
using System.Text;

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
    private List<string> entries = new List<string>();

    public void AnswerPrompts(int promptCount)
    {
        // make is so user can only put in the max number of prompts available
        promptCount = Math.Min(promptCount, PromptList.Length);

        // Loop to prompt the user for answers then assign it to the prompt
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
    public void LoadEntries(string entriesData)
    {
        entries.Clear();
        string[] loadedEntries = entriesData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        entries.AddRange(loadedEntries);
        Console.WriteLine("Entries loaded successfully.");
    }

    public string SaveEntries()
    {
        StringBuilder sb = new StringBuilder();
        foreach (string entry in entries)
        {
            sb.AppendLine(entry);
        }
        Console.WriteLine("Entries prepared for saving.");
        return sb.ToString();
    }
}