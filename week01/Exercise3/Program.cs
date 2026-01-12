using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int guess = 0;
        do
        {
            Console.WriteLine("What is your guess?");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magic != guess);
    }
}