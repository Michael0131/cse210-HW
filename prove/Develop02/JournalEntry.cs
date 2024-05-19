using System;
using System.Collections.Generic;
using System.IO;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Answer { get; set; }
    public DateTime Timestamp { get; }

    public JournalEntry(string prompt, string answer, DateTime timestamp)
    {
        Prompt = prompt;
        Answer = answer;
        Timestamp = DateTime.Now;
    }
}  
