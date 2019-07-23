using Areas;
using System;

public class Triangle: IShape
{
    double baseLength, breath;
    public Triangle(double side)
    {
        baseLength = Math.Sqrt(3) * side;
        breath = side / 2;
    }
    public Triangle(double baseLength, double height)
	{
        this.baseLength = baseLength;
        this.breath = height;

    }
    public Triangle(double side1,double side2,double side3)
    {
        double side = (side1 + side2 + side3) / 2;
        this.baseLength=Math.Sqrt(side*(side-side1))*2;
        this.breath = Math.Sqrt((side - side2) * (side - side3));
    }
    public  double CalculateArea()
    {
        return (0.5 * baseLength * breath);
    }
}
