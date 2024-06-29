class EternalGoal : Goal
    {
        public int TimesCompleted { get; private set; }

        public EternalGoal(string name, string type, string description, int points) 
            : base(name, type, description, points)
        {
            TimesCompleted = 0;
        }

        public override void MarkComplete()
        {
            TimesCompleted++;
        }

        public override int GetPoints()
        {
            return Points * TimesCompleted;
        }

        public override string ToString()
        {
            return $"[E] {Name} - {Description} - {Points} points each time, completed {TimesCompleted} times";
        }
    }