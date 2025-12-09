using System.ComponentModel;

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();// made this int instead of void due to this phrase in the Eternal Quest Design statement: 
    // It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string line = $"[ ] {_shortName} ({_description})";
        if (IsComplete() == true)
        {
            line = $"[X] {_shortName} ({_description})";
        }
        return line;
    }

    public abstract string GetStringRepresentation();

}