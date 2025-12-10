class RunningActivity : ExerciseActivity
{
    float _distance;
    public RunningActivity(int length, float distance) :base(length)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        float speed = GetDistance() / _length * 60;
        return speed;
    }
    public override float GetPace()
    {
        float pacer = 60/GetSpeed();
        return pacer;
    }
}