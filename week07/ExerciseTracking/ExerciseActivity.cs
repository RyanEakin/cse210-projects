abstract class ExerciseActivity
{
    protected string _date = DateTime.Now.ToString("dd MMM yyyy");
    protected int _length = 0;

    public ExerciseActivity(int length)
    {
        _length = length;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetSummary()
    {
        return $"{_date} {this.GetType()} ({_length} min)- Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph,Pace: {GetPace():0.0} min per mile";
    }
}