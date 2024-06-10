using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Michael Johnson", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Ashlyn Johnson", "Fractions", "8.21", "15-27");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Tanner S.", "Modern America", "The Influence of Inflation");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}