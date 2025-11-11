class Program // menu
{
    // added a portion to the PromptGenerator code so that it doesn't repeat the same prompt
    // unless at least five more unique prompts have been given.
    // thus ensuring the prompts don't repeat right after or almost right after the last writing.
    // it is located at lines: 33-48 of the class PromptGenerator.cs

    static void Main(string[] args)
    {
        Journal jrnl = new Journal();
        PromptGenerator pg = new PromptGenerator();

        string fileName = "";
        bool quit = false;


        Console.WriteLine("Welcome to the Journal Project.");
        while (quit != true) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {

                case "1": // Write
                    userChoice = "";
                    Entry newEntry = new Entry();
                    newEntry._promptText = pg.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    Console.Write("~> ");
                    newEntry._entryText = Console.ReadLine();
                    newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                    jrnl.AddEntry(newEntry);
                    break;

                case "2": // Display
                    userChoice = "";
                    jrnl.DisplayAll();
                    break;

                case "3": // Load
                    userChoice = "";
                    Console.WriteLine("What is the filename?");
                    fileName = Console.ReadLine();
                    jrnl.LoadFromFile(fileName);
                    break;
                case "4": // Save
                    userChoice = "";
                    Console.WriteLine("What is the filename?");
                    fileName = Console.ReadLine();
                    jrnl.SaveToFile(fileName);
                    break;
                case "5": // Quit
                    quit = true;
                    break;
            }
        }
    }
}