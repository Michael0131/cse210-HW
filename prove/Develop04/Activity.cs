using System.Diagnostics;
using System;
using System.Threading;
using System.ComponentModel;
class Activity
{
    public string ActivityName{get; set;}
    public string Description{get; set;}

    protected Activity(string activityName, string description)
    {
        ActivityName = activityName;
        Description = description;

    }
    public void StartActivity(int duration)
    {
        DisplayWelcome(duration);
        SimulateActivity(duration);
        DisplayGoodBye(duration);
    }
    
    protected void DisplayWelcome(int duration)
    {
        Console.WriteLine($"Welcome to the {ActivityName} activity.");
        Console.WriteLine(Description);
        Console.WriteLine($"This activity will be {duration} seconds.");
        ShowCountdown(10);
    }

    protected void DisplayGoodBye(int duration)
    {
        Console.WriteLine($"Thanks for doing the {ActivityName} activity!");
        Console.WriteLine($"You completed this activity in {duration} seconds!");
        ShowCountdown(10);

    }
    // I was shown how to do this printing countdown by AI
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("And Start!");
    }
    protected void SimulateActivity(int duration)
    {
        // Base simulation logic
        Console.WriteLine($"Simulating {ActivityName} activity for {duration} seconds...");
        Thread.Sleep(duration * 1000); // Simulate activity duration
    }

}