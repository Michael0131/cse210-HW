using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //create an input for the user to enter
        Console.Write("What is your grade in '%': ");

        // have program capture and assign variable
        
        //create empty string for variabel grade_assignment

        string grade_assignment = "";


        string answer = Console.ReadLine();
        // change string to int
        double grade_percent = double.Parse(answer);

        // test code before moving on

        // if (grade_percent >= 0)
        // {
        //     Console.WriteLine("Test pass");
        // }
        // }
        if (grade_percent >=90.0)
        {
            grade_assignment = "A";

        }
        else if (grade_percent >=80.0)
        {
            grade_assignment = "B";

        }
        else if (grade_percent >=70.0)
        {
            grade_assignment = "C";

        }
        else if (grade_percent >=60.0)
        {
            grade_assignment = "D";

        }
        else
        {
            grade_assignment = "F";
        }
        // give grammar

        if (grade_percent >=70.0)
        {
            if (grade_assignment == "A" || grade_assignment == "F")
            {
            Console.WriteLine($"You recieved an {grade_assignment}");
            Console.WriteLine($"Congratulations you Passed!");
             
            }
            else
            {
                Console.WriteLine($"You recieved a {grade_assignment}");
                Console.WriteLine($"Congratulations you Passed!");
            }

        }
        else
        {
            if (grade_assignment == "F")
            {
            Console.WriteLine($"You recieved an {grade_assignment}");
            Console.WriteLine($"Maybe study more... Better luck next time!");
             
            }
            else
            {
                Console.WriteLine($"You recieved a {grade_assignment}");
                Console.WriteLine($"Maybe study more... Better luck next time!");
            }

        }





    }
}