class Menu
{
    private PromptJournal journal = new PromptJournal();
    private Dictionary<string, Action> choices;

    public Menu()
    {
        choices = new Dictionary<string, Action>
        {
            { "1", WriteEntry },
            { "2", DisplayEntries },
            { "3", LoadEntries },
            { "4", SaveEntries },
            { "5", Quit }
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\nJournal Menu:");
        Console.WriteLine("1. Write Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Load Entries");
        Console.WriteLine("4. Save Entries");
        Console.WriteLine("5. Quit");
    }
    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter an option: ");
            string choice = Console.ReadLine();

            if (choices.ContainsKey(choice))
            {
                choices[choice]();
            }
            else
            {
                Console.WriteLine($"{choice} is not an option.");
            }
        }
    }

    public void WriteEntry()
    {
        Console.Write("How many prompts would you like to answer? ");
        if (int.TryParse(Console.ReadLine(), out int promptCount))
        {
            journal.AnswerPrompts(promptCount);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        
    }
    public void DisplayEntries()
    {
        journal.DisplayJournal();

    }
    private void LoadEntries()
    {
        Console.Write("Enter the entries to load (use \\n to separate entries): ");
        string entriesData = Console.ReadLine().Replace("\\n", Environment.NewLine);
        journal.LoadEntries(entriesData);
    }
    public void SaveEntries()
    {
        string entriesData = journal.SaveEntries();
        Console.WriteLine("Entries to save:");
        Console.WriteLine(entriesData);

    }
    public void Quit()
    {
        Console.WriteLine("Thank you for your entries... See you tomorrow!");
        Environment.Exit(0);


    }


}