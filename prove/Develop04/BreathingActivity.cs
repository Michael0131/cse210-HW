class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        StartActivity();
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            elapsedTime += 3;
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 3;
        }
        EndActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
