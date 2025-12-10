class BikingActivity : ExerciseActivity
{
    float _speed;

    public BikingActivity(int length, float speed) :base(length)
    {
      _speed = speed;  
    }

    public override float GetDistance()
    {
        float dist = _speed * _length / 60;
        return dist;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        float pacer = 60/GetSpeed();
        return pacer;
    }
}