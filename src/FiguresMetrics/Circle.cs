using FiguresMetrics.Exceptions;

namespace FiguresMetrics
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;

            IsCorrect();
        }

        public double GetArea() => double.Pi * _radius * _radius;

        public void IsCorrect()
        {
            if (_radius <= 0)
            {
                throw new CircleException("The circle must have positive radius!");
            }
        }
    }
}
