using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle { Radius = 5 };

            var excepted = 78.53981633974483;
            var actual = circle.CalculateArea();

            Assert.Equals(actual, excepted);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };

            var excepted = 6;
            var actual = triangle.CalculateArea();

            Assert.Equals(actual, excepted);
        }

        [Test]
        public void RectangularTriangleCheck()
        {
            Triangle triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };

            Assert.Equals(true, triangle.isRectangular());
        }
    }
}
