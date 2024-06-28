class ChecklistGoal : Goal
    {
        public int TargetCount { get; private set; }
        public int CurrentCount { get; private set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
        {
            TargetCount = targetCount;
            CurrentCount = 0;
            BonusPoints = bonusPoints;
        }

        public override void MarkComplete()
        {
            if (!Completed)
            {
                CurrentCount++;
                if (CurrentCount >= TargetCount)
                {
                    Completed = true;
                }
            }
        }

        public override int GetPoints()
        {
            if (Completed)
            {
                return Points * TargetCount + BonusPoints;
            }
            return Points * CurrentCount;
        }

        public override string ToString()
        {
            string status = Completed ? "[X]" : "[ ]";
            return $"{status} {Name} - {Points} points each time, completed {CurrentCount}/{TargetCount} times, bonus {BonusPoints} points";
        }
    }