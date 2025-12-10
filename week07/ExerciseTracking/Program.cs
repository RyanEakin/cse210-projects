using System;

class Program
{
    static void Main(string[] args)
    {
        List<ExerciseActivity> _exercises = [];

        RunningActivity sprint = new RunningActivity(30,3);
        _exercises.Add(sprint);

        BikingActivity cycling = new BikingActivity(30,6);
        _exercises.Add(cycling);

        SwimmingActivity watersport = new SwimmingActivity(30,97);
        _exercises.Add(watersport);

        foreach(ExerciseActivity e in _exercises)
        {
            Console.WriteLine(e.GetSummary());
        }


    }
}