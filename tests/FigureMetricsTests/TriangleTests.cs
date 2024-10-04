using FiguresMetrics.Exceptions;
using FiguresMetrics;

namespace FigureMetricsTests
{
    public class TriangleTests
    {
        Triangle triangle;

        [SetUp]
        public void Setup()
        {
            triangle = new Triangle(12, 8, 15);
        }

        [Test]
        public void CreateInvalid_NonPositiveSidesTest()
        {
            Assert.Throws<TriangleException>(() => new Triangle(-2, -5, -214));
            Assert.Throws<TriangleException>(() => new Triangle(0, -5, -214));
            Assert.Throws<TriangleException>(() => new Triangle(-2, 0, -214));
            Assert.Throws<TriangleException>(() => new Triangle(-2, -6, 0));
            Assert.Throws<TriangleException>(() => new Triangle(0, 0, -521));
            Assert.Throws<TriangleException>(() => new Triangle(0, -72, 0));
            Assert.Throws<TriangleException>(() => new Triangle(-64, 0, 0));
            Assert.Throws<TriangleException>(() => new Triangle(0, 0, 0));
        }
        [Test]
        public void CreateInvalid_NonTriangleTest()
        {
            Assert.Throws<TriangleException>(() => new Triangle(1, 2, 3));
            Assert.Throws<TriangleException>(() => new Triangle(4, 11, 5));
            Assert.Throws<TriangleException>(() => new Triangle(25, 15, 8));
        }
        [Test]
        public void CreateOK_TriangleValidTest()
        {
            Assert.DoesNotThrow(() => new Triangle(3, 4, 5));
            Assert.DoesNotThrow(() => new Triangle(8, 8, 8));
            Assert.DoesNotThrow(() => new Triangle(10, 8, 12));
        }
        [Test]
        public void AreaOK_Test()
        {
            Assert.That(triangle, Is.Not.Null);

            double p = (triangle.ASide + triangle.BSide + triangle.CSide) / 2;
            Assert.That(triangle.GetArea(), Is.EqualTo(Math.Sqrt(p * (p - triangle.ASide) * (p - triangle.BSide) * (p - triangle.CSide))));
        }
        [Test]
        public void AreaDifferent_Test()
        {
            Assert.That(triangle, Is.Not.Null);

            double p = (triangle.ASide + triangle.BSide + triangle.CSide) / 2;
            Assert.That(triangle.GetArea(), Is.Not.EqualTo(Math.Sqrt(p * (p - triangle.ASide) * (p - triangle.BSide) * (p - triangle.CSide)) - 41));
        }
        [Test]
        public void IsNotRectangular_Test()
        {
            Assert.That(triangle, Is.Not.Null);
            Assert.That(triangle.IsRectangular(), Is.False);
        }
        [Test]
        public void IsRectangular_Test()
        {
            Triangle triangleRect = new Triangle(3, 4, 5);
            Assert.That(triangleRect, Is.Not.Null);
            Assert.That(triangleRect.IsRectangular(), Is.True);
        }
    }
}
