using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");


        Job job1 = new Job();
        job1._jobTitle = "Financial Accountant";
        job1._company = "DingYi";
        job1._startYear = 2018;
        job1._endYear = 2022;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Financial Manager";
        job2._company = "Regain";
        job2._startYear = 2020;
        job2._endYear = 2025;
        // job2.Display();


        Resume MyResume = new Resume();
        MyResume._name = "Tak Yiu wong";

        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);

        MyResume.Display();

        
    }    
}
