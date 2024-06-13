public class ListingActivity : Activity
{
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    private void ExecuteListingActivity(int duration)
    {
        Console.WriteLine("Listing positive aspects of your life...");
        // Simulate listing for specified duration
        Thread.Sleep(duration * 1000);
    }

    public void RunListingActivity(int duration)
    {
        base.RunActivity(duration);
    }

    private void ExecuteActivity(int duration)
    {
        ExecuteListingActivity(duration);
    }
}