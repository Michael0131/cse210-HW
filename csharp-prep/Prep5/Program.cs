using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomeMesage();
        PromptUserName();
        PromptUserNumber();
        DisplayResult();
    

    }
    static int PromptUserNumber()
    {
        Console.Write("PLease enter your favorite number: ")
        string number = Console.ReadLine();
        int number = int.parse(Console.ReadLine());
        retun number;
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
        

    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine(name, + "the square of your number is " + square);
        // return 
    }

}