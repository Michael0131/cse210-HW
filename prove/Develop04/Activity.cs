using System.Diagnostics;
using System;
using System.Threading;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.Marshalling;
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
        Console.Clear();
        Console.WriteLine($"Welcome to the {ActivityName} activity.");
        Console.WriteLine(Description);
        Console.WriteLine($"This activity will be {duration} seconds.");
    }

    protected void DisplayGoodBye(int duration)
    {
        Console.Clear();
        Console.WriteLine($"Thanks for doing the {ActivityName} activity!");
        Console.WriteLine($"You completed this activity in {duration} seconds!");
        // ShowCountdown(10);
        Thread.Sleep(1000);
        return;

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
    
    public void ExecuteActivity(int duration)
    {
        Console.WriteLine($"Simulating {ActivityName} activity for {duration} seconds...");
        System.Threading.Thread.Sleep(duration * 1000); // Simulate activity duration
    }
}