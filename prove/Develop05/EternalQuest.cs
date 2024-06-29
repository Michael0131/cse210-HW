class EternalQuest
    {
        private List<Goal> goals;
        private int score;

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

        public void DisplayGoals()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Total Score: {score}");
        }

        public void SaveData(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(score);
                foreach (var goal in goals)
                {
                    if (goal is SimpleGoal)
                    {
                        writer.WriteLine($"SimpleGoal,{goal.Name},{goal.Description},{goal.Points},{goal.Completed}");
                    }
                    else if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine($"EternalGoal,{goal.Name},{goal.Description},{goal.Points},{eternalGoal.TimesCompleted}");
                    }
                    else if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"ChecklistGoal,{goal.Name},{goal.Description},{goal.Points},{checklistGoal.CurrentCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
                    }
                }
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
                        var goal = new SimpleGoal(name, description, points);
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
                        var goal = new EternalGoal(name, description, points);
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
                        var goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
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