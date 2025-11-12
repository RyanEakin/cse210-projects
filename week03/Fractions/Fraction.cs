using System.ComponentModel;
using System.Numerics;

class Fraction
{
    private int _top;
    private int _bottom;
    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fracStr = _top.ToString() + "/" + _bottom.ToString();
        return fracStr;
    }
    public double GetDecimalValue()
    {
        double decVal = (double)_top / (double)_bottom; // this was hardest due to not knowing about (double) previously
        return decVal;
    }
}