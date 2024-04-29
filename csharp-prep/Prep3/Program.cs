using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    {
    
        int number_guess = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 100);
        while (number_guess !=  number)
        {
            Console.Write("What is your guess? ");
            number_guess =int.Parse(Console.ReadLine());
            //number_guess = Console.ReadLine();
            if (number_guess > number)
            {
                Console.WriteLine("Too High - Go Lower");
            }
            else if (number_guess < number)
            {
                Console.WriteLine("Too Low - Think Higher");
            }
            else
            {
                Console.WriteLine("You are correct, the number is " + number + "!");
            }
        }
    
    }

}

