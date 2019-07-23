using System;
using Xunit;

namespace XUnitTestForArea
{
    public class UnitTest1
    {
        [Fact]
        public void TestForCircle()
        {
            var circle = new Circle(10);
            Assert.Equal(314,circle.CalculateArea());
        }

        [Fact]
        public void TestForRectangle()
        {
            var rectangle = new Rectangle(10, 20);
            Assert.Equal(200,rectangle.CalculateArea());
        }

        [Fact]
        public void TestForSquare()
        {
            var square = new Square(10);
            Assert.Equal(100,square.CalculateArea());
        }

        [Fact]
        public void TestForTriangle()
        {
            var triangle = new Triangle(10, 20);
            Assert.Equal(100,triangle.CalculateArea());
        }

        [Fact]
        public void TestForTriangleWithThreeSides()
        {
            var triangle = new Triangle(5,5,5);
            Assert.Equal(11,Math.Round( triangle.CalculateArea()));
        }

        [Fact]
        public void TestForTriangleWithOneSides()
        {
            var triangle = new Triangle(10);
            Assert.Equal(43, Math.Round(triangle.CalculateArea()));
        }
    }
}
