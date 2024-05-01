using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    {
        int guess_count = 0;
    
        int number_guess = -1;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 100);
        while (number_guess !=  number)
        {
            guess_count += 1;
            Console.Write("What is your guess? ");
            number_guess =int.Parse(Console.ReadLine());
            //number_guess = Console.ReadLine();
            
            if (number_guess > number)
            {
                Console.WriteLine("Too High - Guess Lower");
                
            }
            else if (number_guess < number)
            {
                Console.WriteLine("Too Low - Guess Higher");
            }
            else
            {
                Console.WriteLine("You are correct, the number is " + number + "!");
                Console.WriteLine("Congratulations, it took you " + guess_count +" guesses.");
            }
        }
    
    }

}

