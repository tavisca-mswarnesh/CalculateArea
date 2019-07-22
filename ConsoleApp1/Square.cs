using Areas;
using System;

public class Square: IShape
{
    double side;

    public Square(double side)
    {
        this.side = side;
    }
	
    public  double Area()
    {
        return (side * side);
    }
}
