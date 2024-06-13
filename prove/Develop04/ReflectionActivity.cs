public class ReflectionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity(string activityName, string description) : base(activityName, description)
    {
    }

    private void ExecuteActivity(int duration, string activityName)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

    // Loop until the end time is reached
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Ge ready...");
            Console.WriteLine("");
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("");
            Console.WriteLine(prompts);
            Console.WriteLine("");
            Console.Write("When you have something in mind, press *enter* to continue: ");
            // i got this solution to capture user key press from stack overflow
            var userInput = Console.ReadKey();
            if(userInput.Key == ConsoleKey.Enter)
            {

                
            } 
        }
        Console.WriteLine($"Time's up! Your {activityName} activity is over.");
        // Random random = new Random();
        // for (int i = 0; i < duration; i++)
        // {
        //     string prompt = prompts[random.Next(prompts.Length)];
        //     Console.WriteLine(prompt);
        //     Thread.Sleep(3000); // Pause for reflection
        // }
    }

    public void RunReflectionActivity(int duration)
    {
        DisplayWelcome(duration);
        ExecuteActivity(duration);
        DisplayGoodBye(duration);
    }

    // private void ExecuteActivity(int duration)
    // {
    //     ExecuteReflectionActivity(duration);
    // }
}