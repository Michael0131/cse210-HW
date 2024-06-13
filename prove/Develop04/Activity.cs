using System.Diagnostics;
using System;
using System.Threading;
using System.ComponentModel;
using System.Net.NetworkInformation;
public class Activity
{
    public string ActivityName{get; set;}
    public string Description{get; set;}

    protected Activity(string activityName, string description)
    {
        ActivityName = activityName;
        Description = description;

    }
    // public void StartActivity(int duration)
    // {
    //     DisplayWelcome(duration);
    //     SimulateActivity(duration);
    //     DisplayGoodBye(duration);
    // }
    public void RunActivity(int duration)
    {
        DisplayWelcome(duration);
        ExecuteActivity(duration);
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
        // ShowCountdown(10);

    }
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("And Start!");
    }
    
    private void ExecuteActivity(int duration)
    {
        // i was taught throw new by AI
        throw new NotImplementedException("Each activity must implement its own execution logic.");
    }

}