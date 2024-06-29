class EternalQuest
    {
        private List<Goal> goals;
        private int score;
        private static readonly string DataDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Data");
        public EternalQuest()
        {
            goals = new List<Goal>();
            score = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }
    
        public void RecordEvent(string goalName)
        {
            foreach (var goal in goals)
            {
                if (goal.Name == goalName)
                {
                    goal.MarkComplete();
                    score += goal.GetPoints();
                    break;
                }
            }
        }
       public string GetDataDirectory()
            {
                return DataDirectory;
            }
        public void DisplayGoals()
            {
                int count = 1;
                foreach (var goal in goals)
                {
                    Console.WriteLine($"{count}. {goal.ToString().Trim()}"); // Trim used to ensure no leading/trailing spaces i was shwon this by AI
                    count++;
                }
            }
    //    public void DisplayGoals()
    //         {
    //             // int count = 1;
    //             // foreach (var goal in goals)
    //             // {
    //             //     Console.WriteLine($"Number: {count}"); // Debug output
    //             //     Console.WriteLine($"Goal: {goal}");   // More debug output
    //             //     Console.WriteLine($"{count}. {goal}");  // Final output
    //             //     count++;
    //             // }
    //         }

        public void DisplayScore()
        {
            Console.WriteLine($"Total Score: {score}");
        }

        public void SaveData(string filename)
            {
                string filePath = Path.Combine(DataDirectory, filename);
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(score);
                        foreach (var goal in goals)
                        {
                            writer.WriteLine($"{goal.GoalType},{goal.Name},{goal.Description},{goal.Points},{goal.Completed}");
                            // For checklist goals, make sure to also save target count and bonus points
                            if (goal is ChecklistGoal checklistGoal)
                            {
                                writer.WriteLine($"{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
                            }
                        }
                    }
                    Console.WriteLine("Data saved successfully to " + filePath);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to save data: " + e.Message);
                }
            }
        public List<string> GetAvailableDataFiles()
        {
            try
            {
                var filePaths = Directory.GetFiles(DataDirectory, "*.txt");
                return new List<string>(filePaths);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to retrieve files: " + e.Message);
                return new List<string>(); // Return an empty list on failure
            }
        }

        public void LoadData(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                score = int.Parse(reader.ReadLine());
                goals = new List<Goal>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    string goalType = parts[0];
                    if (goalType == "SimpleGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool completed = bool.Parse(parts[4]);
                        var goal = new SimpleGoal(name, goalType, description, points);
                        if (completed)
                        {
                            goal.MarkComplete();
                        }
                        goals.Add(goal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int timesCompleted = int.Parse(parts[4]);
                        var goal = new EternalGoal(name, goalType, description, points);
                        for (int i = 0; i < timesCompleted; i++)
                        {
                            goal.MarkComplete();
                        }
                        goals.Add(goal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int currentCount = int.Parse(parts[4]);
                        int targetCount = int.Parse(parts[5]);
                        int bonusPoints = int.Parse(parts[6]);
                        var goal = new ChecklistGoal(name, goalType, description, points, targetCount, bonusPoints);
                        for (int i = 0; i < currentCount; i++)
                        {
                            goal.MarkComplete();
                        }
                        goals.Add(goal);
                    }
                }
            }
        }
    }