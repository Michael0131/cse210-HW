class Program
    {
        static void Main(string[] args)
        {
            EternalQuest quest = new EternalQuest();

            while (true)
            {
                Console.WriteLine("\n1. Add Goal\n2. Record Event\n3. Display Goals\n4. Display Score\n5. Save Data\n6. Load Data\n7. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Create New Goal: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine("\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                        Console.Write("Enter goal type: ");
                        string goalType = Console.ReadLine();

                        Goal goal = null;
                        if (goalType == "simple")
                        {
                            goal = new SimpleGoal(name, points);
                        }
                        else if (goalType == "eternal")
                        {
                            goal = new EternalGoal(name, points);
                        }
                        else if (goalType == "checklist")
                        {
                            Console.Write("Enter target count: ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.Write("Enter bonus points: ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            goal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                        }
                        else
                        {
                            Console.WriteLine("Invalid goal type!");
                            continue;
                        }

                        quest.AddGoal(goal);
                        break;

                    case "2":
                        Console.Write("Enter goal name to record: ");
                        string goalName = Console.ReadLine();
                        quest.RecordEvent(goalName);
                        break;

                    case "3":
                        quest.DisplayGoals();
                        break;

                    case "4":
                        quest.DisplayScore();
                        break;

                    case "5":
                        Console.Write("Enter filename to save data: ");
                        string saveFilename = Console.ReadLine();
                        quest.SaveData(saveFilename);
                        break;

                    case "6":
                        Console.Write("Enter filename to load data: ");
                        string loadFilename = Console.ReadLine();
                        quest.LoadData(loadFilename);
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
