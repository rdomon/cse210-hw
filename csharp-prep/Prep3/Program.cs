using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the magic number
        // Console.Write("Enter the magic number: ");
        // int magicNumber = int.Parse(Console.ReadLine());


        // make it loop
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magicNumber)
        {
            // ask the guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!!");
            }
        }
    }
}