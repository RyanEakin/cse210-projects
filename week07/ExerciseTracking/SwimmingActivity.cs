class SwimmingActivity : ExerciseActivity
{
    int _lapAmount;

    public SwimmingActivity(int length, int lapAmount) :base(length)
    {
        _lapAmount = lapAmount;    
    }

    public override float GetDistance()
    {
        float test = _lapAmount * 50;//also apparently this works INSTEAD of just putting it all together. neat
        float dist = test / 1000 * 0.62F; //added the (float) because it kept bugging me about it being a double!!!
        return dist;
    }
    public override float GetSpeed()
    {
        float speed = GetDistance() / _length * 60;
        return speed;
    }
    public override float GetPace()
    {
        float pacer = _length / GetDistance();
        return pacer;
    }
}