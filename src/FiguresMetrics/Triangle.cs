using FiguresMetrics.Exceptions;

namespace FiguresMetrics
{
    public class Triangle : IFigure
    {
        private readonly double _aSide;
        private readonly double _bSide;
        private readonly double _cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;

            IsCorrect();
        }

        public double ASide { get { return _aSide; } }
        public double BSide { get { return _bSide; } }
        public double CSide { get { return _cSide; } }

        public double GetArea()
        {
            double p = (_aSide + _bSide + _cSide) / 2;
            return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));
        }
        public bool IsRectangular()
        {
            if (_aSide * _aSide + _bSide * _bSide == _cSide * _cSide || _aSide * _aSide + _cSide * _cSide == _bSide * _bSide
                || _bSide * _bSide + _cSide * _cSide == _aSide * _aSide)
            {
                return true;
            }
            return false;
        }

        public void IsCorrect()
        {
            if (_aSide <= 0 || _bSide <= 0 || _cSide <= 0)
            {
                throw new TriangleException("Triangle must have positive sides!");
            }
            if (_aSide + _bSide <= _cSide || _aSide + _cSide <= _bSide || _bSide + _cSide <= _aSide)
            {
                throw new TriangleException("The figure is not triangle!");
            }
        }
    }
}
