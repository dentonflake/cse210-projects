using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        bool isPlayAgain = false;

        do
        {
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int count = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                count++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} guesses!");
                }
            }
            while (guess != magicNumber);

            Console.Write("Play again? (y/n): ");
            string response = Console.ReadLine();

            if (response == "y") {
                isPlayAgain = true;
            }
        }
        while (isPlayAgain);
    }
}