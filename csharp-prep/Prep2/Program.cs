using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

    // Core Requirement 1 to ask for the grade percentage and then print the corresponding grade
        if (gradePercent >= 90)                    
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradePercent >=80 && gradePercent <= 89)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradePercent >= 70 && gradePercent <= 79)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradePercent >= 60 && gradePercent <=69)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else 
        {
            Console.WriteLine("Your letter grade is F.");
        }

     // Core Requirement 2 to generate messages for the result
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulation! You pass.");
        }
        else
        {
            Console.WriteLine("Work hard next time");
        }

    // Core Requirement 3 to re-write 1 to simpler code
        string letter = "";
        if (gradePercent >= 90)
        {
           letter = "A";
        }
        else if (gradePercent >=80 && gradePercent <= 89)
        {
           letter = "B";
        }
        else if (gradePercent >= 70 && gradePercent <= 79)
        {
            letter = "C";
        }
        else if (gradePercent >= 60 && gradePercent <=69)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
    Console.WriteLine($"{letter}");
    }
}