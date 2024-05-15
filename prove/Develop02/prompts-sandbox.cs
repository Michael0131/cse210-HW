using System;
using System.Collections.Generic;

class PromptJournal
{
    private string[] PromptList = new string[]
    {
      "What did you have for breakfast?",
        "Did you do anything fun today?",
        "Did you meet anyone new today?",
        "Did you particapte in class or go to work today?",
        "Did you do anthing you havent doen before today?",
        //make more this is a test  
    };

    private List<string> answers = new List<string>();
    private Random random = new Random();

    public void AnswerPrompts(int promptCount)
    {
        for (int i = 0; i < promptCount; i++)
        {
            int index = random.Next(PromptList.Length);
            Console.WriteLine($"Prompt {i + 1}: {PromptList[index]}");
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();
            answers.Add(answer);
        }
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        for (int i = 0; i < answers.Count; i++)
        {
            Console.WriteLine($"Prompt {i + 1}: {answers[i]}");
        }
    }
}

