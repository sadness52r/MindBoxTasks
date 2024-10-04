using FiguresMetrics;
using FiguresMetrics.Exceptions;

namespace FigureMetricsTests
{
    public class CircleTests
    {
        Circle circle;

        [SetUp]
        public void Setup()
        {
            circle = new Circle(9);
        }

        [Test]
        public void CreateInvalid_NonPositiveRadiusTest()
        {
            Assert.Throws<CircleException>(() => new Circle(-5));
            Assert.Throws<CircleException>(() => new Circle(0));
        }
        [Test]
        public void CreateOK_PositiveRadiusTest()
        {
            Assert.DoesNotThrow(() => new Circle(6));
        }
        [Test]
        public void AreaOK_Test()
        {
            Assert.That(circle, Is.Not.Null);
            Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 81));
        }
        [Test]
        public void AreaDifferent_Test()
        {
            Assert.That(circle, Is.Not.Null);
            Assert.That(circle.GetArea(), Is.Not.EqualTo(Math.PI * 21));
        }
    }
}