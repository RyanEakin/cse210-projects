class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "this activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        for(int t=0; t < _duration/10; t++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}