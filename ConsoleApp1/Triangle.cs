using Areas;
using System;

public class Triangle: IShape
{
    double baseLength, breath;
    public Triangle(double baseLength, double height)
	{
        this.baseLength = baseLength;
        this.breath = height;

    }
    public  double Area()
    {
        return (0.5 * baseLength * breath);
    }
}
