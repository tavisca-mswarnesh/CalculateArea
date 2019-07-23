using Areas;
using System;

public class Rectangle : IShape
{
    double length, breath;
    public Rectangle(double length,double breath)
    {
        this.length = length;
        this.breath = breath;
    }
    public  double CalculateArea()
    {
        return (length * breath);
    }

}
