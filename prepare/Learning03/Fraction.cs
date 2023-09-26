using System.Dynamic;

public class Fraction  //the fraction class
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //sets default to 1/1
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
        _top  = top;
        _bottom = bottom;
    }



    public string GetfractionString()
    {
        //this is not permanent it is recomputed every time this is called
        string text = $"{_top} / {_bottom}"; // this is a way of  storing outputs into a variable
        return text;

    }


    public double GetDecimalValue()
    {
        //This will be recomputed each time this is called;
        return (double)_top / (double) _bottom;
    }
}

