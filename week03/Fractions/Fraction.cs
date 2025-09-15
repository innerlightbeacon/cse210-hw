using System;

public class Fraction
{
    // Private attributes (encapsulation)
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction() // default constructor: 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top) // single parameter constructor: top/1
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // two parameter constructor: top/bottom
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and setters
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
        if (bottom != 0) // Prevent divide by zero
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Keeping previous value.");
        }
    }

    // Method: return as "top/bottom"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method: return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
