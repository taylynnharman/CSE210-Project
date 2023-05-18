using System;

public class Fraction {
    //attributes for top and bottom numbers
    private int _top;
    private int _bottom;
    
    //constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //constructor that will make numerator a whole number
    public Fraction(int number)
    {
        //initialize bottom to 1
        _top = number;
        _bottom = 1;
    }
    //constructor for a top and bottom ?
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString(){
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }

}