using System.Net.NetworkInformation;

class ListingActivity : Activity
{

    int _count;
    List<string> _prompts = new List<string> {
        "Describe your ideal day from morning to night, including the small details that make it special.",
        "List the things you are grateful for today and explain why each one is significant to you.",
        "Describe a moment from your childhood that still brings you joy. explain the details that made it memorable for you.",
        "Compile a list of books mentioned within your current read, noting which ones you'd like to explore next and why.",
        "Create a list of characters you love to hate, detailing what makes them compelling or relatable.",
        "List the most impactful quotes from your current read and explain why they resonate with you."
    };
    List<string> _prevPrompt = new List<string>();

    public ListingActivity()
    {
        _name = "ListingActivity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt:");
        string selectedPrompt = GetRandomPrompt();
        Console.WriteLine(selectedPrompt);

        Console.Write("you may begin in: ");
        ShowCountDown(5);

        List<string> reply = GetListFromUser();
        _count = reply.Count;
        Console.WriteLine("");

        Console.WriteLine($"You Listed {_count} items!");

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        string promptChoice = _prompts[rand.Next(0, _prompts.Count -1)];
        // this randomly selects the previous prompt from the list, 
        // this is the case because 15 isn't counted, but considered the ending number and will not be called upon
        // though with the rand.Next refering to a number it must be placed within the "[ ]" to be noted as an index location
        // this leads to the index being called and the value being extracted and placed within the variable promptChoice

        // start of addition
        // this code block checks if the Prompt generated has already been used previously in a recent point;
        // if it was reused, then it will regenerate the prompt until it changes to something different
        while (_prevPrompt.Contains(promptChoice))
        {
            promptChoice = _prompts[rand.Next(0, _prompts.Count -1)];
        }

        _prevPrompt.Add(promptChoice);

        // this makes sure that the list doesn't get to long and also so that prompts can resume after a period of entries
        if (_prevPrompt.Count > 5)
        {
            _prevPrompt.RemoveAt(0);
        }
        // end of addition

        return promptChoice;
    }

    public List<string> GetListFromUser()
    {
        DateTime beginTime = DateTime.Now; // put this here due to the fact that the further THIS DateTime block is,
        //  the worse the effect upon timing
        DateTime endTime = beginTime.AddSeconds(_duration);

        List<string> entryList = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            entryList.Add(entry);
        }

        return entryList;
    }
}