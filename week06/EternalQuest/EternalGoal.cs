class EternalGoal : Goal
{
    int _timesCompleted = 0; //added this to check for how many times the eternal program has been "completed" for scoring purposes
    public EternalGoal(string name, string description, int points) :base(name,description,points)
    {
               
    }

    public override int RecordEvent()// made this int instead of void due to this phrase in the Eternal Quest Design statement: 
    // It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    {
        _timesCompleted++; //added this to record the times this is called for recalling score
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string line =$"EternalGoal:::{_shortName}:::{_description}:::{_points}:::{_timesCompleted}";
        return line;
    }
}