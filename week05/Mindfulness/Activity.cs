using System.Collections;
using System.Runtime.Versioning;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "this is the base class for activities";
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Hello this is the {_name}; {_description}");
        Console.WriteLine("");
        Console.Write("how long, in seconds, would you like for your session?: ");
        int durationAmount = int.Parse(Console.ReadLine());
        _duration = durationAmount;
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("good job.");
        ShowSpinner(10);

        Console.WriteLine($"the {_name} of {_duration} seconds has been completed");
        ShowSpinner(10);

        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (futureTime > currentTime)
        {
            foreach(var frame in frames)
            {
                Console.Write(frame);
                currentTime = DateTime.Now;
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
            
        }
        Console.Write(new string(' ', Console.WindowWidth)); //clears throbber line after finished
        Console.SetCursorPosition(0, Console.CursorTop - 1); //sets cursor position back to start
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds) 
    // I modified the countdown function to have a check to see if the duration is a single, double, triple, or quad digit number
    {
        while (seconds > 0)
        {
            int timeLength = seconds.ToString().Length;
            Console.Write(seconds);

            Thread.Sleep(1000);
            seconds = seconds -1;

            switch (timeLength) {
                case 1:
                Console.Write("\b \b");
                break;

                case 2:
                Console.Write("\b \b\b");
                break;

                case 3:
                Console.Write("\b \b\b\b");
                break;

                case 4:
                Console.Write("\b \b\b\b\b");
                break;

            }
            
        }
        Console.Write(new string(' ', Console.WindowWidth)); //clears countdown line after finished
        Console.SetCursorPosition(0, Console.CursorTop - 1); //sets cursor position back to start
        Console.WriteLine();
    }
    
}