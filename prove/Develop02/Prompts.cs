using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;

class PromptJournal
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();
    private string[] PromptList = new string[]
    {
        "What did you have for breakfast?",
        "Did you do anything fun today?",
        "Did you meet anyone new today?",
        "Did you participate in class or go to work today?",
        "Did you do anything you haven't done before today?",
        "Tell me about what you did for fun today.",
        "Did you have any fun activites you did with friends today?",
        "What did you do this morning to prepare for the day?",
        "Did you have any memorable dreams last night?",
        "How was your communte to work or school?",
        "Did you overcome any challanges? If you did, how did you overcome them?"
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
            
            // answers.Add(answer);
            journalEntries.Add(new JournalEntry(PromptList[i], answer, DateTime.Now));
        }
    }

    public void DisplayJournal()
    {
        // Display journal entries
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in journalEntries)
        {
            // Print each prompt along with its corresponding answer
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Answer: {entry.Answer}\n");
            Console.WriteLine($"Timestamp: {entry.Timestamp}\n");

        }
    }
    public void LoadEntries(string fileName)
{
    try
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length >= 2) // Ensure there are at least two parts (prompt and answer)
            {
                string prompt = parts[0];
                string answer = parts[1];
                
                // Always use DateTime.Now for timestamp when loading entries
                DateTime timestamp = DateTime.Now;

                if (parts.Length >= 3 && DateTime.TryParse(parts[2], out DateTime parsedTimestamp))
                {
                    timestamp = parsedTimestamp; // Use parsed timestamp if available
                }

                journalEntries.Add(new JournalEntry(prompt, answer, timestamp));
            }
        }
        Console.WriteLine("Entries loaded successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading entries: {ex.Message}");
    }
}
    // public void LoadEntries(string fileNAme)
    // {
    //     journalEntries.Clear();
    //     try
    //     {
    //         string[] lines =File.ReadAllLines(fileNAme);
    //         foreach (string line in lines)
    //         {
    //             string[] parts = line.Split("|");
    //             if (parts.Length == 2);
    //             {
    //                 journalEntries.Add(new JournalEntry(parts[0], parts[1]));
    //             }
    //         }
    //         Console.WriteLine("Your entries have loaded successfully! ");            
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"There was an error loading your entries: {ex.Message} ");
    //     }
    // }

    public void SaveEntries(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    writer.WriteLine($"{entry.Prompt}|{entry.Answer}");
                }
            }
            Console.WriteLine("Your entries saved successfully! ");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"There was an error saving your entries: {ex.Message}");
        }
    }

}