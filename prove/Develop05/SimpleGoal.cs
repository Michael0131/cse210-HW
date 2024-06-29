class SimpleGoal : Goal
    {
         public SimpleGoal(string name, string type, string description, int points) 
            : base(name, type, description, points) { }

        public override void MarkComplete()
        {
            Completed = true;
        }

        public override int GetPoints()
        {
            return Points;
        }
    }