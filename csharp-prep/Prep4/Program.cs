using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_input = -1;
        //string user_variable = "Hello";
        int List_size = 0;

        Console.WriteLine("Enter  alist of numbers, type '0' when you are done. ");
        while (user_input != 0)
        {
            Console.Write("Enter a number:");
            
            string user_response = Console.ReadLine();
            user_input = int.Parse(user_response);
            
        
            if (user_input != 0)
            {
                numbers.Add(user_input);
            }

        }
        List_size = numbers.Count;
        int sum =0;

        foreach (int number in numbers)
        {
            
            sum += number;

    
        }
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine($"The average is: " + sum/List_size);
        // Find largest
        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine("The Largest number is: " + max);
        



        
    }
}