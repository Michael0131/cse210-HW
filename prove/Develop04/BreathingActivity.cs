public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    private void ExecuteBreathingActivity(int duration)
    {
        Console.WriteLine($"Simulating {ActivityName} activity for {duration} seconds...");
        Thread.Sleep(duration * 1000); // Simulate activity duration
    }

    public void RunBreathingActivity(int duration)
    {
        base.RunActivity(duration);
    }

    private void ExecuteActivity(int duration)
    {
        ExecuteBreathingActivity(duration);
    }
}