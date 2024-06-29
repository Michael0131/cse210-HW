using System.Runtime.InteropServices;
using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        EternalQuest quest = new EternalQuest();

        while (true)
        {
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    var (type, name, description, points) = Goal.GetGoalInfo();

                    Goal goal = null;
                    if (type == "simple")
                    {
                        goal = new SimpleGoal(name, type, description, points);
                        Console.Clear();
                        Console.WriteLine("Saving Progress....");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                    else if (type == "eternal")
                    {
                        goal = new EternalGoal(name, type, description, points);
                        Console.Clear();
                        Console.WriteLine("Saving Progress....");
                        Thread.Sleep(500);
                        Console.Clear();
                    }
                    else if (type == "checklist")
                    {
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        goal = new ChecklistGoal(name, type, description, points, targetCount, bonusPoints);
                        Console.Clear();
                        Console.WriteLine("Saving Progress....");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type!");
                        continue;
                    }

                    quest.AddGoal(goal);
                    Console.Clear();
                    Console.WriteLine("Saving Progress....");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                case "2":
                    quest.DisplayGoals();
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("Going back to menu....");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                case "3":
                    Console.Write("Enter filename to save data: ");
                    string saveFilename = Console.ReadLine();
                    quest.SaveData(saveFilename);
                    Console.Clear();
                    Console.WriteLine("Saving Progress....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;

                case "4":
                    var files = quest.GetAvailableDataFiles();
                    if (files.Count == 0)
                    {
                        Console.WriteLine("No saved files available.");
                        break;
                    }
                    
                    Console.WriteLine("Available files:");
                    foreach (var file in files)
                    {
                        Console.WriteLine(Path.GetFileName(file));
                    }

                    Console.Write("Enter the filename to load data: ");
                    string filename = Console.ReadLine();
                    quest.LoadData(filename);
                    Console.Clear();
                    Console.WriteLine("Loading File....");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("File Found!");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;

                case "5":
                    Console.WriteLine("Available Goals:");
                    quest.DisplayGoals();
                    Console.Write("Enter goal name to record: ");
                    string goalName = Console.ReadLine();
                    quest.RecordEvent(goalName);
                    Console.Clear();
                    Console.WriteLine($"Saving Progress.... ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Score updated!");
                    quest.DisplayScore();
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;

                case "6":
                    quest.DisplayScore();
                    Thread.Sleep(2500);
                    Console.Clear();
                    Console.WriteLine("Going back to menu....");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                case "7":
                    return;  // Exit the application

                default:
                    Console.WriteLine("Invalid option!");
                    Console.Clear();
                    Console.WriteLine("Saving Progress....");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
            }
        }
    }
}
