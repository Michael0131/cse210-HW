class EternalGoal : Goal
    {
        public int TimesCompleted { get; private set; }

        public EternalGoal(string name, int points) : base(name, points)
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
            return $"[E] {Name} - {Points} points each time, completed {TimesCompleted} times";
        }
    }