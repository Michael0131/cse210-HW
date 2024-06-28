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
                        writer.WriteLine($"SimpleGoal,{goal.Name},{goal.Points},{goal.Completed}");
                    }
                    else if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine($"EternalGoal,{goal.Name},{goal.Points},{eternalGoal.TimesCompleted}");
                    }
                    else if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"ChecklistGoal,{goal.Name},{goal.Points},{checklistGoal.CurrentCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}");
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
                        int points = int.Parse(parts[2]);
                        bool completed = bool.Parse(parts[3]);
                        var goal = new SimpleGoal(name, points);
                        if (completed)
                        {
                            goal.MarkComplete();
                        }
                        goals.Add(goal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        int timesCompleted = int.Parse(parts[3]);
                        var goal = new EternalGoal(name, points);
                        for (int i = 0; i < timesCompleted; i++)
                        {
                            goal.MarkComplete();
                        }
                        goals.Add(goal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        int currentCount = int.Parse(parts[3]);
                        int targetCount = int.Parse(parts[4]);
                        int bonusPoints = int.Parse(parts[5]);
                        var goal = new ChecklistGoal(name, points, targetCount, bonusPoints);
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