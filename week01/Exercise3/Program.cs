using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int ChosenNumber = randomGenerator.Next(1, 101);
        string UserGuess = "";
        int Guess = 0;
        int GuessCount = 0;
        string Replay = "yes";

        Console.WriteLine("What is your guess? ");
        
        while (Replay != "no")
        {
            
            UserGuess = Console.ReadLine();
            Guess = int.Parse(UserGuess);

            if (Guess > ChosenNumber)
            {
                Console.WriteLine("lower, Guess Again!");
                GuessCount++;
            }
            else if (Guess < ChosenNumber)
            {
                Console.WriteLine("higher, Guess Again!");
                GuessCount++;
            }
            else
            {
                Console.WriteLine("Correct!");
                Console.WriteLine($"it took you {GuessCount} tries!");

                Console.WriteLine("Do you want to play again? type 'yes' if so.");
                Replay = Console.ReadLine();

                if (Replay != "yes")
                {
                    Replay = "no";
                }
                else
                {
                    ChosenNumber = randomGenerator.Next(1, 101);
                    GuessCount = 0;
                    Console.WriteLine("What is your guess? ");
                }
            }
        }
    }
}