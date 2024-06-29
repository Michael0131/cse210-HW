using System.Runtime.CompilerServices;

abstract class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public bool Completed { get; protected set; }

        public Goal(string name, string description, int points)
        {
            
            Name = name;
            Description = description;
            Points = points;
            Completed = false;
        }
        public static (string name, string description, int points) GetGoalInfo()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());
            return (name, description, points);
        }

        public abstract void MarkComplete();
        public abstract int GetPoints();

        public override string ToString()
        {
            string status = Completed ? "[X]" : "[ ]";
            return $"{status} {Name} - {Points} points";
        }
    }