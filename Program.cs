using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int MagicNumber = 42;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("I'm thinking of a number between 1 - 100, can you guess what it is?");

            string guess = Console.ReadLine();
            int UserNumber = int.Parse(guess);

            int i = 1;
            while (i <= 4)
            {
                Console.WriteLine(i);
                i++;
            }

            // int attempts = 4;
            // for (int i = 0; i < attempts; i++)
            // {
            //     Console.WriteLine($"Try again: {attempts - i - 1} more time");
            // }

            // Console.WriteLine("I was thinking of " + MagicNumber);
            // Console.WriteLine("You guessed " + UserNumber);

            if (UserNumber == MagicNumber)
            {
                Console.WriteLine("You got it right! Are you a wizard?");
            }
            else
            {
                Console.WriteLine("Sorry, that's not the number I was thinking of. You can try " +
                    i + " more times.");
            }

        }

    }
}