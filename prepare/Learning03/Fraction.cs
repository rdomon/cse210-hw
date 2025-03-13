using System;

class Fraction
{
    private int _top;  //numerator;
    private int _bottom; //decemalnator


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;

    }
}