using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int MagicNumber = new Random().Next(1, 100);
            // Console.WriteLine(MagicNumber);

            int attempts = 5;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < attempts; i++)
            {
                Console.WriteLine($"I'm thinking of a number between 1 - 100, can you guess what it is? You have { attempts - i - 1} guesses left!");
                string guess = Console.ReadLine();
                int UserNumber = int.Parse(guess);

                if (UserNumber == MagicNumber)
                {
                    Console.WriteLine("You got it right! Are you a wizard?");
                    break;
                }
                else
                {
                    if (UserNumber < MagicNumber)
                    {
                        Console.WriteLine("Sorry, the number is higher than that!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the number is lower than that!");
                    }
                }
            }
        }

    }
}