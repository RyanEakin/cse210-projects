class Circle : Shape
{
    double _radius;

    public Circle(double radius, string color):base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double areaAmount = 3.14 * (_radius * _radius);
        return areaAmount;
    }
}