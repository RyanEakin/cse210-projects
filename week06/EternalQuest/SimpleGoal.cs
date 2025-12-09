using System.ComponentModel;

class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, int points) :base(name,description,points)
    {
        _isComplete = false;
    }

    public override int RecordEvent() // made this int instead of void due to this phrase in the Eternal Quest Design statement: 
    // It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string line =$"SimpleGoal:::{_shortName}:::{_description}:::{_points}:::{_isComplete}";
        return line;
    }
}