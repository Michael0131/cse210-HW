using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

abstract class Goal
    {
        // private static int counter = 0;
        public string Name { get; set; }

        public string GoalType { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public bool Completed { get; protected set; }

        public Goal(string name, string type, string description, int points)
        {
            
            Name = name;
            GoalType = type;
            Description = description;
            Points = points;
            Completed = false;
        }
        public static (string type, string name, string description, int points) GetGoalInfo()
        {
            Console.Write("Enter goal type (simple/eternal/checklist): ");
            string type = Console.ReadLine();
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());
            return (type, name, description, points);
        }

        public abstract void MarkComplete();
        public abstract int GetPoints();

        public override string ToString()
        {
            string status = Completed ? "[X]" : "[ ]";
            
            return $" {status} {Name} ({Description}) - {Points} points";
            
    
        }
        // public static void ResetCounter()
        // {
        //     counter = 0;
        // }
    }