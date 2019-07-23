using Areas;
using System;

public class Circle: IShape
{
    public double radius;
	public Circle(double radius)
	{
        this.radius = radius;
	}
    public  double CalculateArea()
    {
        return (3.14 * radius * radius);
    }
}
