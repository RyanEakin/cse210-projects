using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.WriteLine("what was you grade percentage? ");
        string gradePrecent = Console.ReadLine();

        int grade = int.Parse(gradePrecent);

        if (grade >= 90)
        {
            if (grade >= 96)
            {
                letter = "A";    
            }
            else
            {
                letter = "A-";
            }
        }
        else if (grade >= 80)
        { 
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";

        }

        Console.WriteLine($"Your Grade is: {letter}");

        if (grade >= 70)
        {
            Console.Write($" you got an {letter}! Congrats on Passing the Class!");
        }
        else
        {
            Console.Write($"Your grade was {letter}, You Didn't Pass this time. Learn more and try again later!");
        }
    }
}