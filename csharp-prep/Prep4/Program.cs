using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // set up a number list until the user inputs 0
        int userNum = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNum !=0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNum = int.Parse(response);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        // Core #1 : Compute the sum of the numbers in the list.
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}"); 

        // Core #2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // Core #3: Find the max
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max)
            {
                 max = number;
            }
        }
        Console.WriteLine($"The largest number is {max}");
    }
}