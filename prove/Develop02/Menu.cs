class Menu
{
    private PromptJournal _journal = new PromptJournal();
    private Dictionary<string, Action> _choices;

    public Menu()
    {
        _choices = new Dictionary<string, Action>
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

            if (_choices.ContainsKey(choice))
            {
                _choices[choice]();
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
            _journal.AnswerPrompts(promptCount);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    public void DisplayEntries()
    {
        _journal.DisplayJournal();
    }

    public void SaveEntries()
    {
        Console.Write("Enter the file name to save entries to: ");
        string fileName = Console.ReadLine();
        _journal.SaveEntries(fileName);
    }

    private void LoadEntries()
    {
        Console.Write("Enter the file name to load entries from: ");
        string fileName = Console.ReadLine();
        _journal.LoadEntries(fileName);
        _journal.DisplayJournal();
    }

    public void Quit()
    {
        Console.WriteLine("Thank you for your entries... See you tomorrow!");
        Environment.Exit(0);
    }
}
