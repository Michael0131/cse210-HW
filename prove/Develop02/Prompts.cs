using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;

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
    private List<string> usedPrompts = new List<string>();

}