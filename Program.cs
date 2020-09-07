using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int MagicNumber = new Random().Next(1, 100);

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("I'm thinking of a number between 1 - 100, can you guess what it is?");

            string guess = Console.ReadLine();
            int UserNumber = int.Parse(guess);

            Console.WriteLine("You guessed " + UserNumber);
        }

    }
}