using System.Data;
using System.Net;

class CheckListGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) :base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override int RecordEvent()// made this int instead of void due to this phrase in the Eternal Quest Design statement: 
    // It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    {
        if (_amountCompleted != _target)
        {
            _amountCompleted++;
        }
        if (IsComplete() == true)
        {
            _points += _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        bool stateComplete = false;
        if (_amountCompleted == _target)
        {
            stateComplete = true; 
        }
        return stateComplete;
    }

    public override string GetDetailsString()
    {
        string line = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        if (IsComplete() == true)
        {
            line = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return line;
    }
    public override string GetStringRepresentation()
    {
        string line =$"CheckListGoal:::{_shortName}:::{_description}:::{_points}:::{_bonus}:::{_amountCompleted}:::{_target}";
        return line;
    }
}