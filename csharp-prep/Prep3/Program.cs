using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number?  ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;    
        
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guess it!");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                 Console.WriteLine("Higher");
            }
        }
    }
}
