using System;


class Program
{ //modified the Scripture.cs file, specifically the HideRandomWords() function, so that it will not re-hide hidden words.

    static void Main(string[] args)
    {
        bool closeStatus = false;

        Reference thrift = new Reference("D&C",89,10);
        Scripture purse = new Scripture(thrift,"And again, verily I say unto you, all wholesome herbs God hath ordained for the constitution, nature, and use of man");


        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        while (closeStatus == false) {
            string displayText = purse.GetDisplayText();
            Console.WriteLine(displayText);
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string userInput = Console.ReadLine();

            if (userInput == "quit" || purse.IsCompletelyHidden() == true)
            {
                closeStatus = true;
            }
            purse.HideRandomWords(3);
            Console.Clear();
        }
    }
}