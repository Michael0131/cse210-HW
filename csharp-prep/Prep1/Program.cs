using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        
        // get the first name
        // create the prompt for user to input
        Console.Write("enter your first name:");
        //have C# capture the input, and assign it a variable
        string first_name= Console.ReadLine();
        //capture the last name
        Console.Write("Enter your last name:");
        // have C# capture the last name
        string last_name = Console.ReadLine();

        // create print function to introduce user like bond
        Console.WriteLine($"Your name is {last_name}, {first_name}  {last_name} ");




    }
}