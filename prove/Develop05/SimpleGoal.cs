class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void MarkComplete()
        {
            Completed = true;
        }

        public override int GetPoints()
        {
            return Points;
        }
    }