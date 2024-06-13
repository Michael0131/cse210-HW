using System;
using System.Data.Common;
using System.Runtime.InteropServices;

class Program
{
    DateTime startTime = DateTime.Now;

    static void Main(string[] args)
{
    Console.WriteLine("Welcome to the Mindfulness Activities App!\n");

    while (true)
    {
        // Display menu options
        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listing Exercise");
        Console.WriteLine("4. Exit");

        // Get user choice
        Console.Write("Enter your choice (1-4): ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.WriteLine();
            continue;
        }

        // Perform action based on user choice
        if (choice == 1)
        {
            PerformBreathingExercise();
        }
        else if (choice == 2)
        {
            int duration = GetDurationFromUser();
            PerformReflectionExercise(duration, "Reflection Exercise");
        }
        else if (choice == 3)
        {
            PerformListingExercise();
        }
        else if (choice == 4)
        {
            Console.Clear();
            Console.WriteLine("Good Bye, see you next time!");
            Thread.Sleep(1000);
            return;
        }
    }
}

    static void PerformBreathingExercise()
    {
        Console.WriteLine("\nYou've chosen the Breathing Exercise.");
        Console.WriteLine("");
        int duration = GetDurationFromUser();
        Console.WriteLine("");
    }
//     static void PerformReflectionExercise()
//     {
//         Console.WriteLine("\nYou've chosen the Reflection Exercise.");
//         int duration = GetDurationFromUser(); // Get duration from user input
//         string activityName = "Reflection Exercise"; // Set the activity name
        


// }
    static void PerformReflectionExercise(int duration, string activityName)
{
    DateTime startTime = DateTime.Now;
    DateTime currentTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(duration);
    if (currentTime < futureTime)
    {
        Console.WriteLine($"\nYou've chosen the {activityName}.");
        Console.WriteLine("");
        ReflectionActivity reflectionActivity = new ReflectionActivity(activityName, "Reflect on past experiences.");
        reflectionActivity.RunReflectionActivity(duration);
    }
    Console.WriteLine("Time is up...");
    Console.WriteLine($"Your {activityName} activity is over.");
}


    static void PerformListingExercise()
    {
        Console.WriteLine("\nYou've chosen the Listing Exercise.");
        int duration = GetDurationFromUser();
        ListingActivity listingActivity = new ListingActivity("Listing Exercise", "List positive aspects of your life.");
        listingActivity.RunListingActivity(duration);
    }
    static int GetDurationFromUser()
    {
        int duration = 0;
    
        Console.WriteLine("How long would you like to do this exercise? *seconds* ");
        if (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Error");
            return 0;
        }
        
        return duration;


    }




    // static int GetDurationFromUser()
    // {
    //     Console.Write("How long do you want to perform the activity? (Enter duration in seconds): ");
    //     if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
    //     {
    //         Console.WriteLine("Invalid input for duration. Please enter a valid number greater than 0.");
    //         return 0;
    //     }
    //     return duration;
    // }   
}