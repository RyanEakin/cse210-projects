using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int Number  = PromptUserNumber();
        int Square  = SquareNumber(Number);
        DisplayResult(Name,Square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int UserNumber = int.Parse(Console.ReadLine());
        return UserNumber;
    }
    static int SquareNumber(int args)
    {
        int Squared = args * args;
        return Squared;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}