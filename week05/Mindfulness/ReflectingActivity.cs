class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string> {
        "Describe a person who inspires you and write down the qualities they possess that resonate with your own aspirations for growth.",
        "Think of a time when you stood up for someone else.",
        "Identify a fear that's been holding you back lately. Explore its origin and brainstorm small steps to confront it.",
        "Think of a time when you did something really difficult.",
        "Identify a lesson from one of your challenges",
        "Think of a time when you helped someone in need.",
        "Describe a recent dream you had and reflect on what it might reveal about your current life or feelings.",
        "Think of a time when you did something truly selfless."
        };
    List<string> _questions = new List<string> {
        "what happened to inspire you?",
        "Why was this experience meaningful to you?",
        "what was the origin and how did it come to be?",
        "Have you ever done anything like this before?",
        "how can you apply the lesson moving forward?",
        "What is your favorite thing about this experience?",
        "what did it reveal about you or your current feelings?",
        "How can you keep this experience in mind in the future?"
        };

    List<string> _prevPrompt = new List<string>();

    List<string> _prevQuestion = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {

        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt:\n");

        DisplayPrompt();
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("you may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime beginTime = DateTime.Now; // put this here due to the fact that the further THIS DateTime block is,
        //  the worse the effect upon timing
        DateTime endTime = beginTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        TimeSpan difference = endTime - currentTime;
        int totalSeconds = (int)difference.TotalSeconds;

        while (endTime > currentTime) {
            DisplayQuestions();
            currentTime = DateTime.Now;
            ShowSpinner(totalSeconds/2);
        }
        Console.WriteLine("");

        DisplayEndingMessage();
        Console.Clear();
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

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        string questionChoice = _questions[rand.Next(0, _questions.Count -1)];
        // this randomly selects the previous prompt from the list, 
        // this is the case because 15 isn't counted, but considered the ending number and will not be called upon
        // though with the rand.Next refering to a number it must be placed within the "[ ]" to be noted as an index location
        // this leads to the index being called and the value being extracted and placed within the variable promptChoice

        // start of addition
        // this code block checks if the Prompt generated has already been used previously in a recent point;
        // if it was reused, then it will regenerate the prompt until it changes to something different
        while (_prevQuestion.Contains(questionChoice))
        {
            questionChoice = _questions[rand.Next(0, _questions.Count -1)];
        }

        _prevQuestion.Add(questionChoice);

        // this makes sure that the list doesn't get to long and also so that prompts can resume after a period of entries
        if (_prevQuestion.Count > 5)
        {
            _prevQuestion.RemoveAt(0);
        }
        // end of addition

        return questionChoice;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}