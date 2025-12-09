using System;

class Program
{ // added an option to delete goals in the menu from _goals list in the GoalManager.cs file
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager menu = new GoalManager();

        menu.Start(); //initialize the menu
    }   
}   