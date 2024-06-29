class SimpleGoal : Goal
    {
         public SimpleGoal(string name, string description, int points) 
            : base(name, description, points) { }

        public override void MarkComplete()
        {
            Completed = true;
        }

        public override int GetPoints()
        {
            return Points;
        }
    }