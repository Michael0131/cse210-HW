using System;
using System.Security.Cryptography.X509Certificates;

public class Prompts
{
    //make a string array to call to
    String[] promptList = new string[]
    {
        "What did you have for breakfast?",
        "Did you do anything fun today?",
        "Did you meet anyone new today?",
        "Did you particapte in class or go to work today?",
        "Did you do anthing you havent doen before today?",
        //make more this is a test           
    };

    //ask user how many promtps they would like to answer
    Console.Write("How many questions do you want to answer? ");
    int promptCount = int.Parse(Console.ReadLine());
    Console.WriteLine("Working");


    // store user response as list to be displayed later.

    List<string> answers = new List<string>();

    //create random for generation

    Random random = new Random();

    // create a loop to print the number of prompts the user wants to answer

    for (int i = 0; i < promptCount; i++)
    {
        //generate random location within the lenght of prompt list

        int index = random.Next(promptList.Length);

        // prompt user with the prompt and store answer

        Console.WriteLine($"Promt {i + 1}: {promptList[index]}");
        Console.Write("Answer");
        string answer = Console.ReadLine();

        answers.Add(answer);
    }
    // Output the answers for journaling
    Console.WriteLine("\nAnswers for Journaling:");
    for (int i = 0; i < promptCount; i++)
    {
        Console.WriteLine($"Prompt {i + 1}: {answers[i]}");
    }
       

    
}