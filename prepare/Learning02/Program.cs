using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        // assign job info for job 1 below
        Job job1 = new Job();
        job1._jobtitle = "Software Engineer";
        job1._company = "Microsoft";
        //do not assign years as string but int
        job1._startYear = 2019;
        job1._endYear = 2022;
        // do same for job 2
        Job job2 = new Job();
        job2._jobtitle = "Manager";
        job2._company = "Apple";
        //do not assign years as string but int
        job2._startYear = 2022;
        job2._endYear = 2023;

        //call and create resume

        Resume userResume = new Resume();
        userResume._name= "Allison Rose";
        
        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);

        userResume.Display();




    }
}