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
            Assert.Equal(314,circle.Area());
        }

        [Fact]
        public void TestForRectangle()
        {
            var rectangle = new Rectangle(10, 20);
            Assert.Equal(200,rectangle.Area());
        }

        [Fact]
        public void TestForSquare()
        {
            var square = new Square(10);
            Assert.Equal(100,square.Area());
        }

        [Fact]
        public void TestForTriangle()
        {
            var triangle = new Triangle(10, 20);
            Assert.Equal(100,triangle.Area());
        }
    }
}
