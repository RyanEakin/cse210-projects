using System;
using System.ComponentModel;
using System.Net.Quic;

class Program
{
    // in Activity.cs file I modified the ShowCountDown function to be aware of the amount of digits when clearing previous numbers
    // I also added my previous addition from my Journal program to the GetRandomPrompt() methods
    //  of the ListingActivity.cs and ReflectingActivity.cs classes
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        bool quit = false;


        while (quit != true) {
            Console.WriteLine("Menu Options: \n  1. Start breathing activity \n  2. Start reflecting activity \n  3. Start listing activity");
            Console.Write("  4. Quit \nSelect a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            //action.ShowSpinner(15);

            //action.ShowCountDown(10);

            switch (userInput)
            {
                case 1:
                    //BreathingActivity
                    breath.Run();
                    break;

                case 2:
                    //ReflectingActivity
                    reflect.Run();
                    break;

                case 3:
                    //ListingActivity
                    listing.Run();
                    break;

                case 4:
                    //Quit
                    quit = true;
                    break;


            }
        }
    }
}