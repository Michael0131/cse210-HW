abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool Completed { get; protected set; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
            Completed = false;
        }

        public abstract void MarkComplete();
        public abstract int GetPoints();

        public override string ToString()
        {
            string status = Completed ? "[X]" : "[ ]";
            return $"{status} {Name} - {Points} points";
        }
    }